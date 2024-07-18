using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Levels : MonoBehaviour
{
    public Rigidbody rb;
    float moveIffset = 0.5f;
    public Button[] buttons;
    private bool Moveright;
    private bool Moveleft;
    private float horizontalmove;
    float speed = 5 ;


    // Start is called before the first frame update
    void Start()
    {

        Moveleft = false;
        Moveright = false;


        for (int i = 0; i < buttons.Length; i++)
        {
            int k = i;
            buttons[i].GetComponentInChildren<Text>().text = "" + (i + 1);
            buttons[i].onClick.AddListener(() =>
            {
                print("clickbutton" + k);
                PlayerPrefs.SetInt("Levels", k + 1);
                SceneManager.LoadScene("Level " + (k + 1));

            });
        }
    }

    // Update is called once per frame
    void Update()
    {
        Moveplayer();
    }
    public void btnlevel()
    {
        //print("clickedddd====>>>>>>>>>");
        SceneManager.LoadScene("Levels");

    }

    public void btnRestart()
    {
        int lv = PlayerPrefs.GetInt("Levels");
        PlayerPrefs.SetInt("Levels", (lv));
        SceneManager.LoadScene("Level " + (lv));
    }


    public void btnNext()
    {
        int levl = PlayerPrefs.GetInt("Levels");
        SceneManager.LoadScene("Level " + (levl + 1));
    }
     
    public void btnLeft() 
    {
        /*//print("buttonType  -->  it's change" );
        Vector3 position = user.transform.position;
        position.x = Mathf.Max(position.x - moveIffset);
        user.transform.position = position;*/

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector3(-5, 0, 0);
        }
    }
    public void btnRight()
    {
        /*Vector3 position = user.transform.position;
        position.x = Mathf.Min(position.x + moveIffset);
        user.transform.position = position;*/

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector3(5, 0, 0);
        }
        
    }

    public void pointerdownRight()
    {
        Moveright = true;
    }
    public void pointerupright()
    {
        Moveright=false;
    }
    public void pointerdownleft()
    {
        Moveright = true;
    }
    public void pointerupleft()
    {
        Moveright = false;
    }

    public void Moveplayer()
    {
        if(Moveleft)
        {
            horizontalmove = -speed;
        }
        else if(Moveright)
        {
            horizontalmove = speed;
        }
        else
        {
            horizontalmove = 0;
        }
    }


}
