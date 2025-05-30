using UnityEngine;

namespace Scripts.Characters
{
    public class Player : Person
    {
        [SerializeField] private int experience;

        protected int Experience
        {
            get{return experience;}
        }

        /*public override void ShowStats()
        {
            base.ShowStats();
            Debug.Log($"Your experience is: {experience}");
        }*/
    
        protected override void TakeDamege(int damageValue)
        {
            Health -= damageValue;
        
            Debug.Log($"My name is {UserName}. After hitting with force {damageValue}. I have health: {Health}"); 
        }

        void Start()
        {
            //ShowStats();
            TakeDamege(30);
        }
    }
}

