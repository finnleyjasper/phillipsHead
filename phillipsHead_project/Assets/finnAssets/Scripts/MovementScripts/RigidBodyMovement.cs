using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Vector3 startPosition = new Vector3(0, 0, 0);

    [SerializeField] int jumpForce;
    [SerializeField] int force;

    [SerializeField] Rigidbody rb;

    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // handles left and right movement
        // y value takes whatever the jumpness is at that moment so moving left/right/up/down does not canel jump or visa verca
        rb.velocity = new Vector3(horizontalInput * force, rb.velocity.y, verticalInput * force);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
        }

        if (Input.GetButtonDown("Submit"))
        {
            gameObject.transform.position = startPosition;
        }
    }

    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
    }

    bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, groundLayer);
    }
}

