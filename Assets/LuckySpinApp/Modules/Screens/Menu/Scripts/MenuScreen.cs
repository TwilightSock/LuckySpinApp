using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

namespace LuckySpinApp.Screens.Menu
{
    public class MenuScreen : BaseTemplateScreen
    {
        public const string Exit_Play = "Exit_Play";
        

        public void OnExitPressed()
        {
            Exit(Exit_Play);
        }
        
    }
}
