using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBackward : MonoBehaviour
{
    public float velocity = 25.0f;

    private SahilController sahilControllerScript;
    
    // Start is called before the first frame update
    void Start()
    {
        sahilControllerScript = GameObject.Find("SahilController").GetComponent<SahilController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (true)
        {
            transform.Translate(Vector3.back * Time.deltaTime * velocity);
        }
    }
}
