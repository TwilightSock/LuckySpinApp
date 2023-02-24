using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LuckySpinApp.UIElements
{
    public class OutputUIE : UIElement
    {
        [SerializeField] private GameObject itemPrefab;
        public void OutputItem(Sprite _sprite)
        {
            InstantiateItem().gameObject.GetComponent<Image>().sprite = _sprite;
        }

        private GameObject InstantiateItem()
        {
            if (gameObject.transform.childCount == 0 )
            {
                GameObject _item = Instantiate(itemPrefab, new Vector3(0, 0,1), Quaternion.identity);
                if (_item != null)
                {
                    _item.transform.SetParent(gameObject.transform);
                    _item.transform.localScale = new Vector2(1, 1);
                    _item.transform.localPosition = new Vector3(0, 0, 0);
                
                    return _item;
                }
            }
            
            return gameObject.transform.GetChild(0).gameObject;

        }
    }
}
