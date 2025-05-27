using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;

    [SerializeField] private float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();
    }

    public void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name);
    }

    public void MovePlayer()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(-1f * moveSpeed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(Vector3.right * moveSpeed);
        }
        else
        {
            rigidbody.linearVelocity = Vector3.zero;
        }
    }
}
