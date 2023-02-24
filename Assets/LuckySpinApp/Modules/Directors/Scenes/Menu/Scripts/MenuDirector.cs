using System.Collections;
using System.Collections.Generic;
using LuckySpinApp.Screens;
using UnityEngine;
using LuckySpinApp.Screens.Menu;
using UnityEditor;
using UnityEngine.SceneManagement;

namespace LuckySpinApp.Directors
{
    public class MenuDirector : BaseSceneDirector
    {
        protected override void Start()
        {
            base.Start();
            AddExitAction<MenuScreen>(OnMenuScreenExit);
            AddExitAction<DailyScreen>(OnDailyScreenExit);
            //AddExitAction<>();
            //AddExitAction<>();
            SetCurrentScreen<MenuScreen>().Show();
        }

        void OnMenuScreenExit(string _exitCode)
        {
            switch (_exitCode)
            {
                case MenuScreen.Exit_App:
                    Application.Quit();
                    break;
                case MenuScreen.Exit_Start:
                    SceneManager.LoadScene(SceneIds.Game);
                    break;
                case MenuScreen.Exit_Daily:
                    ToScreen<DailyScreen>();
                    break;
                case MenuScreen.Exit_Settings:
                    //ToScreen<>();
                    break;
                case MenuScreen.Exit_Privacy:
                    //ToScreen<>();
                    break;
                case MenuScreen.Exit_Rules:
                    //ToScreen<>();
                    break;
            }
        }

        void OnDailyScreenExit(string _exitCode)
        {
            switch (_exitCode)
            {
                case DailyScreen.Exit_Pick:
                    ToScreen<MenuScreen>();
                    break;
            }
        }
    }
}
