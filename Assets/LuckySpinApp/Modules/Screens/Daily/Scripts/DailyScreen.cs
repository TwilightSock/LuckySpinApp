using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LuckySpinApp.Screens
{
    public class DailyScreen : BaseTemplateScreen
    {
        public const string Exit_Pick = "Exit_Pick";
        
        
        public void OnPickPressed()
        {
            Exit(Exit_Pick);
        }
        
        
    }
}
