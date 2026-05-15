using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float gravity = -9.81f;

    
    private CharacterController cc;
    private Vector3 velocity;
    private Vector3 move;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        cc.Move(move * speed * Time.deltaTime);

        if (cc.isGrounded && cc.velocity.y < 0)
        {
            velocity.y = -2f;
        }
        
        velocity.y += gravity * Time.deltaTime;
        cc.Move(velocity * Time.deltaTime);
    }
    
    private void OnMove(InputValue value)
    {
        var v2 = value.Get<Vector2>();
        move = transform.right * v2.x + transform.forward * v2.y;
    }
}
