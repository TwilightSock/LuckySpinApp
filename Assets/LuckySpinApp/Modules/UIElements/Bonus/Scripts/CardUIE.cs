using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LuckySpinApp.UIElements
{
    public class CardUIE : UIElement
    {
        [SerializeField] private GameObject safeSymbol;
        public void OnMouseDown()
        {
            
                safeSymbol.SetActive(false);
                IsOpened = true;
            
        }

        public void Reveal()
        {
            safeSymbol.SetActive(true);
        }

        public bool IsOpened { get; set; } = false;
    }
}
