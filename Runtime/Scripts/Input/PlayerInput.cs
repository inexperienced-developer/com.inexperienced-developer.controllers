using UnityEngine;

namespace InexperiencedDeveloper.Controllers.Input
{
    public class PlayerInput : MonoBehaviour
    {
        public PlayerInputActions InputActions { get; private set; }

        public void Init()
        {
            InputActions = new PlayerInputActions();
            InputActions.Enable();
        }

        private void OnDisable()
        {
            InputActions.Disable();
        }

        public Vector2 Move => InputActions.Player.Movement.ReadValue<Vector2>();
        public Vector2 Look => InputActions.Player.Look.ReadValue<Vector2>();
        public bool Jump => InputActions.Player.Jump.WasPressedThisFrame();

        public bool LeftClick => InputActions.Player.LeftClick.WasPressedThisFrame();
        public bool LeftClickHeld => InputActions.Player.LeftClick.IsPressed();
        public bool LeftClickCx => InputActions.Player.LeftClick.WasReleasedThisFrame();
        public Vector2 MousePos => InputActions.Player.MousePos.ReadValue<Vector2>();
        public bool ShiftHeld => InputActions.Player.Shift.IsPressed();
        public bool CtrlHeld => InputActions.Player.Ctrl.IsPressed();
    }
}

