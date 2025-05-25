using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody rigidbody;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 0.06f)
        {
            rigidbody.useGravity = false;
        }
    }
}
