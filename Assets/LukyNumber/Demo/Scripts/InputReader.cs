using UnityEngine;
using UnityEngine.InputSystem;

namespace LuckyNumber
{
    [RequireComponent(typeof(PlayerInput))]
    public class InputReader : MonoBehaviour
    {
        PlayerInput _playerInput;
        InputAction _moveAction;

        public Vector2 Move => _moveAction.ReadValue<Vector2>();

        private void Start()
        {
            _playerInput = GetComponent<PlayerInput>();
            _moveAction = _playerInput.actions["Move"];
        }
    }
}
