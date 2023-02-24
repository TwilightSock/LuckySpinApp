using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace LuckySpinApp.UIElements
{
    public class WheelUIE : UIElement
    {
        [SerializeField] private float wheelSpeed;
        private Vector3 currentEulerAngles;
        private float currentSpeed;
        private int counter;
        private void Start()
        {
            Speed = wheelSpeed;
            counter = 0;
        }

        public void Spin()
        {
            if (IsSpinning)
            {

                transform.Rotate(0,0,currentSpeed * Time.deltaTime);
                /*currentEulerAngles +=  Speed * Time.deltaTime * new Vector3(0, 0, 1) ;
                transform.localEulerAngles = currentEulerAngles;*/
                if (currentSpeed > 0)
                {
                    Stop();
                }
            }

            
        }

        private void Stop()
        {
            currentSpeed--;

            if (currentSpeed <= 0)
            {
                IsSpinning = false;
                Speed = wheelSpeed;
                counter++;
            }
        }

        public float Speed
        {
            get => currentSpeed;
            private set
            {
                float _tempSpeed = Random.Range(value - 300,value + 300);
                if (_tempSpeed <= 900)
                {
                    _tempSpeed = 900;
                }

                currentSpeed = _tempSpeed;
            }
        }

        public bool IsSpinning { get; set; }
        public int CountSpins
        {
            get => counter;
        }
    }
}
