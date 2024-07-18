using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class User : MonoBehaviour
{
    public int Buttontype = 0;
    float Speed = 10;
    float moveIffset = 0.03f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
            
        {
            Vector3 position = transform.position;
            position.z = (position.z + moveIffset);
            transform.position = position;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 position = transform.position;
            position.x = (position.x - moveIffset);
            transform.position = position;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 position = transform.position;
            position.x = (position.x + moveIffset);
            transform.position = position;
        } 
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Opstacle")
        { 
            SceneManager.LoadScene("Gameover");
        }
        if(collision.gameObject.tag == "Win")
        {
            SceneManager.LoadScene("Win");
        }
    }
   
}
