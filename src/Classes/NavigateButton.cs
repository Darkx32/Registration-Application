using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Application
{
    public class NavigateButton
    {
        readonly List<Button> buttons;
        readonly Color defaultColor;
        readonly Color seletedColor;

        public NavigateButton(List<Button> buttons, Color defaultColor, Color seletedColor)
        {
            this.buttons = buttons;
            this.defaultColor = defaultColor;
            this.seletedColor = seletedColor;
        }

        public void SelectButton(int index)
        {
            if (index >= 0 && index < buttons.Count)
            {
                for(int i = 0; i < buttons.Count; i++)
                {
                    if (i == index) { buttons[i].BackColor = seletedColor; }
                    else {buttons[i].BackColor = defaultColor;}
                }
            }
        }
    }
}
