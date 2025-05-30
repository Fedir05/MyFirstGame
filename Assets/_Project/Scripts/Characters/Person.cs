using UnityEngine;

namespace Scripts.Characters
{
    public abstract class Person : MonoBehaviour
    {
        [SerializeField] private string userName;
        [SerializeField] private int health;

        protected string UserName
        {
            get{return userName;}
        }

        protected int Health
        {
            get{return health;}
        
            set
            {
                if (value < 0 || value > 100)
                {
                    return;
                }
            
                health = value;

                if (health < 0)
                {
                    health = 0;
                }
            }
        }

        /*public virtual void ShowStats()
        {
            Debug.Log($"Your name is: {userName}");
        }*/
    
        protected abstract void TakeDamege(int damageValue);
    
        /*void Start()
        {
            ShowStats();
        }*/
    
    }
}

