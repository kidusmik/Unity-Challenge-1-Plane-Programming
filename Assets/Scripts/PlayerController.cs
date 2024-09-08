using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        // This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //This moves the player forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // This turns the player
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
