using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace LuckySpinApp.UIElements
{
    public class ArrowUIE : UIElement
    {
        private Action<Sprite> getItemSprite;
        private void OnTriggerEnter2D(Collider2D _collider)
        {
            Debug.Log("dawdawdad");
            if (_collider.gameObject.GetComponent<ItemUIE>())
            {
                getItemSprite(_collider.GetComponent<ItemUIE>().GetItemSprite);
            }
        }

        public void OnArrowTrigger(Action<Sprite> _action)
        {
            getItemSprite = _action;
        }
    }
}
