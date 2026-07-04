using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ArcadeMaker.Core.ExpSrc;

public abstract record class ExternEngineItem(string Name, string? Desc);

public record class ExternEngineFunc(string Name, string? Desc, MethodInfo Method) : ExternEngineItem(Name, Desc)
{
    public ParamAttribute[] Params = [.. Method.GetCustomAttributes<ParamAttribute>()];
}

public record class ExternEngineProperty(string Name, string? Desc, PropertyInfo Property) : ExternEngineItem(Name, Desc);