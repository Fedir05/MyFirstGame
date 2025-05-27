using UnityEngine;

public class KeyboardMover : MonoBehaviour
{

    [SerializeField] internal Rigidbody rg;
    public float moveSpeed;
    
    void FixedUpdate()
    {
        MovePlayer();
    }

    public void MovePlayer()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rg.AddForce(Vector3.left * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rg.AddForce(Vector3.right * moveSpeed);
        }
        else
        {
            rg.linearVelocity = Vector3.zero;
        }
    }
}
