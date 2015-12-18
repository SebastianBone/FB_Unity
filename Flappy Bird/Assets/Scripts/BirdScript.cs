using UnityEngine;
using System.Collections;

public class BirdScript : MonoBehaviour
{

    // this global variable will be set from the inspector. Represents bird jump force
    public Vector2 jumpForce = new Vector2();

    // function to be executed once the bird is created
    void Start()
    {
        // placing the bird
        transform.position = new Vector2(-2f, 0f);
    }

    // function to be executed at each frame
    void Update()
    {
        // waiting for mouse input
        if (Input.GetButtonDown("Fire1"))
        {
            // setting bird's rigid body velocity to zero
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            // adding jump force to bird's rigid body
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
        }
        // getting the real position, in pixels, of the bird on the stage
        Vector2 stagePos = Camera.main.WorldToScreenPoint(transform.position);
        // if the bird leaves the stage...
        if (stagePos.y > Screen.height || stagePos.y < 0)
        {
            // ... call die function
           
        }
    }
}