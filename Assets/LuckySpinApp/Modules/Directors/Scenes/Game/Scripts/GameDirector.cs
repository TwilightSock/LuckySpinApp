using System.Collections;
using System.Collections.Generic;
using LuckySpinApp.Screens;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LuckySpinApp.Directors
{
    public class GameDirector : BaseSceneDirector
    {
        protected override void Start()
        {
            base.Start();
            AddExitAction<GameScreen>(OnGameScreenExit);
            AddExitAction<BonusScreen>(OnBonusScreenExit);
            
            SetCurrentScreen<GameScreen>().Show();
        }
        
        void OnGameScreenExit(string _exitCode)
        {
            switch (_exitCode)
            {
                case GameScreen.Exit_Menu:
                    SceneManager.LoadScene(SceneIds.Menu);
                    break;
                case GameScreen.Exit_Bonus:
                    ToScreen<BonusScreen>();
                    break;
            }
        }

        void OnBonusScreenExit(string _exitCode)
        {
            switch (_exitCode)
            {
                case BonusScreen.Exit_Menu:
                    SceneManager.LoadScene(SceneIds.Menu);
                    break;
            }
        }
    }
}
