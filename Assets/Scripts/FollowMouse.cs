using UnityEngine;
using UnityEngine.InputSystem;

public class FollowMouse : MonoBehaviour
{
    [SerializeField]
    private InputActionAsset InputActions;
    private InputAction mouseAction;

    [SerializeField]
    private Camera mainCamera;

    void Start()
    {
        InputActions.FindActionMap("Player").Enable();
        mouseAction = InputSystem.actions.FindAction("MousePosition");
    }

    void Update()
    {
        Vector3 screenPosition = mouseAction.ReadValue<Vector2>();
        screenPosition.z = 10f;
        transform.position = mainCamera.ScreenToWorldPoint(screenPosition);
    }
}
