using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LuckySpinApp.UIElements;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

namespace LuckySpinApp.UIControllers
{
    public class BonusUIC : UIController
    {
        
        [SerializeField] private Sprite goldBag;
        [SerializeField] private CardUIE[] allChildCards;
        private int counter = 0;
        protected override void Start()
        {
            
            int _randomNumber = Random.Range(0, allChildCards.Count() - 1);

            Image _image = allChildCards[_randomNumber].GetComponent<Image>();
            _image.sprite = goldBag;
            var _tempColor = _image.color;
            _tempColor.a = 1f;
            _image.color = _tempColor;
        }

        protected override void Update()
        {
            // 5:34 утра. Я пытался. Честно...
            foreach (var card in allChildCards)
            {
                if (card.IsOpened)
                {
                    counter++;
                }
                
            }

            if (counter >= 3)
            {
                /*for (int i = 0; i < allChildCards.Length - 1; i++)
                {
                    allChildCards[i].Reveal();
                }*/
            }

        }
    }
}
