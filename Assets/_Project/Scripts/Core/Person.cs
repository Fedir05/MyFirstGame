using UnityEngine;

public class Person : MonoBehaviour
{
    [SerializeField] private string userName;
    [SerializeField] private int health;

    public string UserName
    {
        get{return userName;}
    }

    public int Health
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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
