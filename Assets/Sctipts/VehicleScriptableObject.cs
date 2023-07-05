using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName = "VehicleScriptableObject", menuName = "ScriptableObejcts/Vehicle")]
public class VehicleScriptableObject : ScriptableObject
{
    //public string Wheel = "Back Wheel"; //wanted this to do tag checks, allow player to select wheels.
    public float speed = 10f;
    public float torque = 1000f;

}
