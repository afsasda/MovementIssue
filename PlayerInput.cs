
using UnityEngine;

namespace RpgLearning
{

    public class PlayerInput : MonoBehaviour
    {
        private Vector3 m_movement;
        public Vector3 MoveInput
        {
            get
            {
                return m_movement;
            }
        }

        public bool isMoveInput
        {
            get
            {
                return !Mathf.Approximately(MoveInput.magnitude, 0);
            }
        }

        
        void Update()
        {
            m_movement.Set(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        }
    }
}
