using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LuckySpinApp.UIElements
{
    public class ItemUIE : UIElement
    {
        [SerializeField] private Sprite itemSprite;

        public Sprite GetItemSprite => itemSprite;
    }
}
