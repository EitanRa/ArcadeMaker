using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using ArcadeMaker.Core.Resources;
using ArcadeMaker.Core.Resources.Serializeables;
using ArcadeMaker.Core.Runtime;
using Exp;
using Exp.Spans;

namespace ArcadeMaker.Core.Models
{
    public class ObjectModel : IModel
    {
        public string Name { get; }
        public Sprite? Sprite { get; }
        public ClassDefSpan Class { get; }
        public ObjectEvent[] Events { get; }
        public (int Depth, bool Visible, bool Solid) InitValues { get; set; }
        public ObjectProperty[] ExtraProperties { get; }

        internal ObjectEvent? CreateEvent { get; }
        internal ObjectEvent? StepEvent { get; }
        internal ObjectEvent? DrawEvent { get; }

        public ObjectModel(string name, Sprite? sprite, ObjectEvent[] events, ObjectProperty[] extraProperties)
        {
            this.Name = name;
            this.Sprite = sprite;
            this.ExtraProperties = extraProperties;

            this.Class = CreateClass(name, extraProperties); // create a class for this object model
            events.ForEach(e => e.CreateDocs(this.Class));
            
            this.Events = events;

            CreateEvent = GetEvent(ObjectEvent.EventType.Create);
            StepEvent   = GetEvent(ObjectEvent.EventType.Step);
            DrawEvent   = GetEvent(ObjectEvent.EventType.Draw);
        }

        private static ClassDefSpan CreateClass(string name, ObjectProperty[] extraProps)
        {
            // create properties
            List<Property> props = [];
            foreach (var property in Runtime.Instance.csProperties)
            {
                props.Add(new(def: null /*(assigned at ClassDefSpan's ctor)*/, false, property.Key.Name.StartWithLowerCase(), false, false));
            }
            foreach (var property in extraProps)
            {
                props.Add(new(def: null /*(assigned at ClassDefSpan's ctor)*/, property.Constant, property.Name, property.Private, false));
            }

            return new ClassDefSpan(name, [..props], []);
        }

        internal ObjectEvent? GetEvent(ObjectEvent.EventType type)
        {
            return Events.FirstOrDefault(e => e.Type == type);
        }

        internal ObjectEvent? GetEvent<T>(ObjectEvent.EventType type, T param)
        {
            return Events.OfType<ParameterizedObjectEvent<T>>().FirstOrDefault(e => e.Type == type && EqualityComparer<T>.Default.Equals(e.Param, param));
        }
    }

    public class ObjectEvent(ObjectEvent.EventType type, IEnumerable<string> scripts, params string[] scriptArgs)
    {
        public enum EventType
        {
            KeyDown,
            KeyUp,
            KeyPress,
            Create,
            Step,
            MouseDown,
            MousePress,
            MouseUp,
            //MouseMove,
            MouseWheel,
            Draw,
            Alarm
        }

        public EventType Type => type;
        public List<string> Scripts { get; } = scripts.ToList();

        [XmlIgnore]
        public List<InstanceScriptDocument>? Docs { get; private set; }

        public string[] ScriptArgs => scriptArgs;

        internal void CreateDocs(ClassDefSpan def)
        {
            //if (Docs != null)
            //    throw new InvalidOperationException("Documents were already been created.");

            Docs = new List<InstanceScriptDocument>();
            for (int i = 0; i < Scripts.Count; i++)
            {
                Docs.Add(new InstanceScriptDocument($"{Type} event of object {def.Name} (Script {i})", def, Scripts[i], ScriptArgs));
            }
        }

        internal void InsertDoc(int index, InstanceScriptDocument doc)
        {
            if (Docs == null)
                throw new InvalidOperationException("Documents were not created.");

            Scripts.Insert(index, doc.Script);
            Docs.Insert(index, doc);
        }

        public virtual bool GetParam(out object? value)
        {
            value = null;
            return false;
        }

        public virtual bool Equals(ObjectEvent? other)
        {
            return other != null && Type == other.Type && Scripts.SequenceEqual(other.Scripts);
        }

        public override string ToString() => Type.ToString();
    }

    public class ParameterizedObjectEvent<T>(ObjectEvent.EventType type, IEnumerable<string> scripts, T param, params string[] scriptArgs) : ObjectEvent(type, scripts, scriptArgs)
    {
        public T Param => param;

        public sealed override bool GetParam(out object? value)
        {
            value = Param;
            return true;
        }

        public override bool Equals(ObjectEvent? other)
        {
            return base.Equals(other) && other is ParameterizedObjectEvent<T> parameterizedOther && EqualityComparer<T>.Default.Equals(Param, parameterizedOther.Param);
        }

        public override string ToString() => $"{base.ToString()} <{Param}>";
    }
}