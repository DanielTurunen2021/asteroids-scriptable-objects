using DefaultNamespace.GameEvents;
using UnityEngine;

namespace DefaultNamespace
{
    public class Mouse : MonoBehaviour
    {
        [SerializeField] private GameEventVector3 _myVector3Event;
        
        
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _myVector3Event.Raise(Input.mousePosition);
            }
        }
    }
}
