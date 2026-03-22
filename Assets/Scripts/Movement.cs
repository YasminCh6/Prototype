 using UnityEngine;
using UnityEngine.InputSystem;
public class Movement : MonoBehaviour
{
    // Public -> Accessor
    // String -> Data type
    public Rigidbody myRigidbody;
    public float movementSpeed = 5.5f;
    public float rotationSpeed = 180f;
    
    // Update is called once per frame
    void Update()
    {
        // A basic condition to check
        // for the W key
        if (Keyboard.current.wKey.isPressed)
        {
            // Push the rigidbody up
            myRigidbody.AddForce(transform.up * movementSpeed * Time.deltaTime);
        }

        if (Keyboard.current.sKey.isPressed)
        {
            // Push the rigidbody down
            myRigidbody.AddForce(transform.up * -1 * movementSpeed * Time.deltaTime);
        }

        if (Keyboard.current.aKey.isPressed)
        {
            myRigidbody.AddTorque(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
        
        if (Keyboard.current.dKey.isPressed)
        {
            myRigidbody.AddTorque(Vector3.back * rotationSpeed * Time.deltaTime);
        }
        
        // Accesses the Transform component
        // transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
        
        
    }
}
