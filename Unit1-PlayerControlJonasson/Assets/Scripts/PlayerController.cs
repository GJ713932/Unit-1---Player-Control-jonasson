using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD

        //THis is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Moves the car forward based on horizontal input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotate the car based on horizontal input 
=======
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
>>>>>>> c47deff28818a437eca9d2641ae7519876dae89d
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}