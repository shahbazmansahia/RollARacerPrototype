using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SahilController : MonoBehaviour
{
    public bool isGameOver = false;
    public bool isGrounded;
    private Rigidbody sahilRb;

    private float forwardInput;
    private float horizontalInput;
    private float velocity = 5.0f;

    private float gravityForce = 1.5f;
    private float jumpForce = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        sahilRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityForce;
        jumpForce = sahilRb.mass * 5.1667f;
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.Space) && isGrounded && (!isGameOver))
        {
            Debug.Log("Jumped!");
            sahilRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        else if (forwardInput > 0)
        {
            transform.Rotate(Vector3.right, Time.deltaTime * velocity);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
