using System;
using System.Collections;
using System.Collections.Generic;
using LuckySpinApp.UIElements;
using TMPro;
using UnityEngine;

namespace LuckySpinApp.UIControllers
{
    public class GameUIC : UIController
    {
        [SerializeField] private WheelUIE wheelElement;
        [SerializeField] private TMP_Text textField;
        private Action onMaxSpinsReached;
        protected override void Update()
        {
            base.Update();

            if (wheelElement.IsSpinning)
            {
                wheelElement.Spin();
                textField.text = $"{wheelElement.CountSpins}/10 Games";
            }

            if (wheelElement.CountSpins == 10)
            {
                onMaxSpinsReached();
            }

        }

        public void MakeSpin()
        {
            wheelElement.IsSpinning = true;
        }

        public void OnMaxSpinsReached(Action _onMaxSpinsReached)
        {
            onMaxSpinsReached = _onMaxSpinsReached;
        }


    }
}
