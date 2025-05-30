using UnityEngine;

namespace Scripts.Characters
{
    public class Dragon : Person
    {
        protected override void TakeDamege(int damageValue)
        {
            Health -= damageValue;
            
            Debug.Log($"I, the mighty dragon, have lost {Health} hitpoints from a hunter`s shot.");
        }

        void Start()
        {
            TakeDamege(25);
        }
    }
}