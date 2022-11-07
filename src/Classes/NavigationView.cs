using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Application
{
    public class NavigationView
    {
        readonly List<UserControl> controlList = new List<UserControl>();
        readonly Panel panel;

        public NavigationView(List<UserControl> controlList, Panel panel)
        {
            this.controlList = controlList;
            this.panel = panel;
            AddUserControls();
        }

        private void AddUserControls()
        {
            for(int i = 0; i < controlList.Count; i++)
            {
                controlList[i].Dock = DockStyle.Fill;
                panel.Controls.Add(controlList[i]);
            }
        }

        public void Display(int index)
        {
            if (index < controlList.Count)
            {
                controlList[index].BringToFront();
            }
        }
    }
}
