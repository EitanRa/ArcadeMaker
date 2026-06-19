using ArcadeMaker.Core.ExpSrc;
using ArcadeMaker.Core.Models;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArcadeMaker.IDE
{
    public partial class SelectEventDialog : Form
    {
        public SelectEventDialog()
        {
            InitializeComponent();
        }

        private void ShowMenu<T>(ObjectEvent.EventType ev, params string[] scriptArgs) where T : struct, Enum
        {
            ContextMenuStrip mainMenu = new();
            Dictionary<string, ToolStripMenuItem> categoriesMenus = [];

            // add menu items based on the enum values
            foreach (var field in typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static)) // we need to get a field in order to get its attributes, so we can't use Enum.GetValues<T>()
            {
                T value = (T)field.GetRawConstantValue()!;
                string? category = field.GetCustomAttribute<Core.ExpSrc.CategoryAttribute>()?.Category;
                bool separate = field.GetCustomAttribute<SeparatorValueAttribute>() != null;

                ToolStripMenuItem menuItem = new(value.ToString()) { Tag = value };
                menuItem.Click += (sender, e) =>
                {
                    SelectEvent(new ParameterizedObjectEvent<T>(ev, [], value, scriptArgs));
                    mainMenu.Dispose();
                };

                if (category != null)
                {
                    ToolStripMenuItem menu;

                    // find or create category menu
                    if (!categoriesMenus.TryGetValue(category, out menu!))
                    {
                        menu = new(category);
                        categoriesMenus.Add(category, menu);
                    }

                    // add the value to the category menu
                    if (separate)
                        menu.DropDownItems.Add(new ToolStripSeparator());
                    menu.DropDownItems.Add(menuItem);
                }
                else
                {
                    // add the value to the main menu
                    if (separate)
                        mainMenu.Items.Add(new ToolStripSeparator());
                    mainMenu.Items.Add(menuItem);
                }
            }

            if (categoriesMenus.Count >= 1)
            {
                if (mainMenu.Items.Count >= 1)
                    mainMenu.Items.Add(new ToolStripSeparator());

                // add all categories menus to the main menu
                mainMenu.Items.AddRange(categoriesMenus.Values.ToArray());
            }

            mainMenu.Show(MousePosition);
        }

        private void SelectEventDialog_Load(object sender, EventArgs e)
        {

        }

        public event EventHandler<ObjectEvent>? EventSelected;

        private void SelectEvent(ObjectEvent ev)
        {
            var handler = EventSelected;
            handler?.Invoke(this, ev);
            Close();
        }

        private void keyDownBtn_Click(object sender, EventArgs e)
        {
            ShowMenu<Core.ExpSrc.Controls.Keys>(ObjectEvent.EventType.KeyDown);
        }

        private void keyUpBtn_Click(object sender, EventArgs e)
        {
            ShowMenu<Core.ExpSrc.Controls.Keys>(ObjectEvent.EventType.KeyUp);
        }

        private void keyPressBtn_Click(object sender, EventArgs e)
        {
            ShowMenu<Core.ExpSrc.Controls.Keys>(ObjectEvent.EventType.KeyPress);
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            SelectEvent(new(ObjectEvent.EventType.Create, []));
        }

        private void stepBtn_Click(object sender, EventArgs e)
        {
            SelectEvent(new(ObjectEvent.EventType.Step, []));
        }

        private void mouseDownBtn_Click(object sender, EventArgs e)
        {
            ShowMenu<Core.ExpSrc.Controls.MouseButton>(ObjectEvent.EventType.MouseDown);
        }

        private void mousePressBtn_Click(object sender, EventArgs e)
        {
            ShowMenu<Core.ExpSrc.Controls.MouseButton>(ObjectEvent.EventType.MouseDown);
        }

        private void mouseUpBtn_Click(object sender, EventArgs e)
        {
            ShowMenu<Core.ExpSrc.Controls.MouseButton>(ObjectEvent.EventType.MouseDown);
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            SelectEvent(new(ObjectEvent.EventType.Draw, []));
        }

        //private void mouseMoveBtn_Click(object sender, EventArgs e)
        //{
        //    SelectEvent(ObjectEvent.MouseMove);
        //}

        private void mouseWheelBtn_Click(object sender, EventArgs e)
        {
            SelectEvent(new(ObjectEvent.EventType.MouseWheel, []));
        }
        private void alarmBtn_Click(object sender, EventArgs e)
        {
            SelectEvent(new(ObjectEvent.EventType.Alarm, []));
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mouseMenuBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) // else the menu will automatically open
                mouseMenuBtn.ContextMenuStrip?.Show(mouseMenuBtn, Point.Empty);
        }
    }
}