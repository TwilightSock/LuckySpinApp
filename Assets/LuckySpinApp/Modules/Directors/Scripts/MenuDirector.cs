using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LuckySpinApp.Screens.Menu;

namespace LuckySpinApp.Directors
{
    public class MenuDirector : BaseSceneDirector
    {
        protected override void Start()
        {
            base.Start();
            AddExitAction<MenuScreen>(OnMenuScreenExit);
        }

        void OnMenuScreenExit(string _exitCode)
        {
            if (_exitCode == MenuScreen.Exit_Play)
            {
                Application.Quit();
            }
        }
    }
}
