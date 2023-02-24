using System.Collections;
using System.Collections.Generic;
using LuckySpinApp.UIControllers;
using LuckySpinApp.UIElements;
using UnityEngine;

namespace LuckySpinApp.Screens
{
    public class GameScreen : BaseTemplateScreen
    {
        public const string Exit_Menu = "Exit_Menu";
        public const string Exit_Bonus = "Exit_Bonus";

        [SerializeField] private ArrowUIE arrowElement;
        [SerializeField] private OutputUIE outputElement;
        [SerializeField] private GameUIC gameUIController;
        protected override void OnEnable()
        {
            base.OnEnable();
            
            arrowElement.OnArrowTrigger(outputElement.OutputItem);
            gameUIController.OnMaxSpinsReached(OnBonusActivated);
        }

        public void OnExitPressed()
        {
            Exit(Exit_Menu);
        }

        public void OnBonusActivated()
        {
            Exit(Exit_Bonus);
        }

        public void OnSpinPressed()
        {
            gameUIController.MakeSpin();
        }
        
        
    }
}
