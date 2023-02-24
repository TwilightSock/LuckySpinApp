using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LuckySpinApp.Screens
{
    public class BonusScreen : BaseTemplateScreen
    {
        public const string Exit_Menu = "Exit_Menu";

        public void OnPickUpPressed()
        {
            Exit(Exit_Menu);
        }
    }
}
