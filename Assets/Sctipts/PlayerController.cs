using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using WheelControl;
using Managers;

public class PlayerController : MonoBehaviour
{
    #region "Controllers & InputActions"
    private PlayerControlls playerControlls;
    private InputAction drive;
    private InputAction.CallbackContext driveContext;
    #endregion

    private bool SpaceBarOn;

    private void Awake()
    {
        playerControlls = new PlayerControlls();
    }

    private void OnEnable()
    {
        drive = playerControlls.Player.Drive;

        //enable
        playerControlls.Enable();
        //subscribe
        drive.performed += OnPress;
    }

    private void OnDisable()
    {
        playerControlls.Disable();
        drive.performed -= OnPress;
    }

    private void OnPress(InputAction.CallbackContext context)
    {
        driveContext = context;

        GameManager.startTimer = true;
    }
}
