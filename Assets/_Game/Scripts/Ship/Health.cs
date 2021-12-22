using UnityEngine;

namespace Ship
{
    public class Health : MonoBehaviour
    {
        private int _health = 10;
        
        private const int MIN_HEALTH = 0;
        
        public void TakeDamage(int damage)
        { 
            Debug.Log($"Took damage: {damage}");
            _health = Mathf.Max(MIN_HEALTH, _health - damage);
        }
    }
}
