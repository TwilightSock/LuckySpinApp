using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

namespace LuckySpinApp.Screens.Menu
{
    public class MenuScreen : BaseTemplateScreen
    {
        public const string Exit_App = "Exit_App";
        public const string Exit_Start = "Exit_Start";
        public const string Exit_Daily = "Exit_Daily";
        public const string Exit_Settings = "Exit_Settings";
        public const string Exit_Privacy = "Exit_Privacy";
        public const string Exit_Rules = "Exit_Rules";
        
        public void OnExitPressed()
        {
            Exit(Exit_App);
        }

        public void OnStartPressed()
        {
            Exit(Exit_Start);
        }
        
        public void OnDailyPressed()
        {
            Exit(Exit_Daily);
        }
        
        public void OnSettingsPressed()
        {
            Exit(Exit_Settings);
        }
        
        public void OnPrivacyPressed()
        {
            Exit(Exit_Privacy);
        }
        
        public void OnRulesPressed()
        {
            Exit(Exit_Rules);
        }

    }
}
