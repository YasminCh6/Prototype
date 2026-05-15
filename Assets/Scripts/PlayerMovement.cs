using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float gravity = -9.81f;
    
    private CharacterController cc;
    private Transform cameraTransform;
    private Vector3 velocity;
    private Vector3 move;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cc = GetComponent<CharacterController>();
        cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Use camera axes projected onto the ground plane for directional movement.
        Vector3 camForward = cameraTransform.forward;
        camForward.y = 0f;
        camForward.Normalize();

        Vector3 camRight = cameraTransform.right;
        camRight.y = 0f;
        camRight.Normalize();

        Vector3 direction = Vector3.ClampMagnitude(camRight * move.x + camForward * move.y, 1f);
        
        cc.Move(direction * speed * Time.deltaTime);

        if (cc.isGrounded && cc.velocity.y < 0)
        {
            velocity.y = -2f;
        }
        
        velocity.y += gravity * Time.deltaTime;
        cc.Move(velocity * Time.deltaTime);
    }
    
    private void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
    }
}
