using Unity.VisualScripting;
using UnityEngine;

public class LocationBuilder : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject exampleGameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
        exampleGameObject.name = "Example";
        
        exampleGameObject.AddComponent<Rigidbody>();
        exampleGameObject.GetComponent<Rigidbody>().useGravity = false;
        
        KeyboardMover mover = exampleGameObject.AddComponent<KeyboardMover>();
        mover.rg = exampleGameObject.GetComponent<Rigidbody>();
        mover.moveSpeed = 50f;
    }
    
}
