using System.Collections;
using System.Collections.Generic;
using LuckySpinApp.UIElements;
using UnityEngine;

namespace LuckySpinApp.UIControllers
{
    public class GameUIC : UIController
    {
        [SerializeField] private WheelUIE wheelElement;   
        protected override void Update()
        {
            base.Update();

            if (wheelElement.IsSpinning)
            {
                wheelElement.Spin();
                
            }

        }
    }
}
