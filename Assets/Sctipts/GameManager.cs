using UnityEngine;
using WheelControl;

namespace Managers
{
    public class GameManager : MonoBehaviour
    {

        public static bool startTimer = false;
        //leave here to come back
        [SerializeField]private float timer;

        public void SetTimeTravelling(WheelJoint2D wheel)
        {
            if (startTimer)
            {
                if (timer > 0)
                {
                    timer -= Time.deltaTime;
                    wheel.useMotor = true;
                    Debug.Log("I On: "+ timer);
                }
                else
                {
                    wheel.useMotor = false;
                    startTimer = false;

                    Debug.Log("I OFF");
                }
            }
        }

        public static void StartMotor(bool b)
        {
            WheelController.wheel.useMotor = b;
        }

        private void Update()
        {
            SetTimeTravelling(WheelController.wheel); //use a corotine instead
        }
    }
}
