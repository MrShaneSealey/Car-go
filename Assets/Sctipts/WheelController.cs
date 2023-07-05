using System.ComponentModel;
using UnityEngine;
using Managers;

namespace WheelControl
{
    public class WheelController : MonoBehaviour
    {
        [SerializeField] private VehicleScriptableObject VSO_;
        public static WheelJoint2D wheel;

        private float speed = 0f;
        private float torque = 0f;

        private void Start()
        {
            wheel = GameObject.FindWithTag("Back Wheel").GetComponent<WheelJoint2D>();
            speed = VSO_.speed; 
            torque = VSO_.torque;

            SetMotorSpeed();
        }
        #region"Driving"
        public void SetMotorSpeed() //wheel //speed
        {
            wheel.motor = new JointMotor2D { motorSpeed = speed, maxMotorTorque = torque };
            wheel.useMotor = false;
        }
            #endregion
    }
}