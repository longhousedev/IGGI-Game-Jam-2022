using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController _controller;
    private Vector3 _velocity;
    private bool _isGrounded;
    public float speed;
    public float jumpHeight;
    private float GRAVITY = -9.81f;
    
    // Start is called before the first frame update
    void Start()
    {
        _controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        _isGrounded = _controller.isGrounded;
        if (_isGrounded & _velocity.y < 0)
        {
            _velocity.y = 0f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        
        _controller.Move(move * (speed * Time.deltaTime));
        
        if (Input.GetKey(KeyCode.Space) && _isGrounded)
        {
            _velocity.y += Mathf.Sqrt(jumpHeight);
        }
        
        _velocity.y += GRAVITY * Time.deltaTime;
        _controller.Move(_velocity * Time.deltaTime);

    }
}
