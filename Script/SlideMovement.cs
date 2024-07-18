using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideMovement : MonoBehaviour
{

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {   
     rb = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {

        /*if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector3(-5, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector3(5, 0, 0);
        }*/
        if (Input.GetMouseButton(0))
        {
            var mouseX = Input.GetAxis("Mouse X");

            rb.velocity = new Vector3(mouseX * 50, 0, 0);
        }

    }

}
