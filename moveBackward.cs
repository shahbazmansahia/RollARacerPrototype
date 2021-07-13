using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBackward : MonoBehaviour
{
    public float velocity = 25.0f;

    public float horizontalInput;

    private SahilController sahilControllerScript;
    
    // Start is called before the first frame update
    void Start()
    {
        sahilControllerScript = GameObject.Find("Sahil").GetComponent<SahilController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (Input.GetAxis("Vertical") > 0)
        {
            transform.Translate(Vector3.back * Time.deltaTime * velocity);
        }

        if (horizontalInput != 0)
        {
            transform.Translate(Vector3.left * Time.deltaTime * velocity * horizontalInput);
        }
    }
}
