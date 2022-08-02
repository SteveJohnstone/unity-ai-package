using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

namespace SteveJstone
{
    public class NavMeshMoveToOnClick : MonoBehaviour
    {
        private NavMeshAgent _agent;

        void Start()
        {
            _agent = GetComponent<NavMeshAgent>();
        }

        public void Update()
        {
            if (Mouse.current.leftButton.wasReleasedThisFrame)
            {
                _agent.destination = Ground.GetMousePosition();
            }
        }
    }
}