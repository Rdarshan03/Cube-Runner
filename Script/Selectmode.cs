using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selectmode : MonoBehaviour
{

    public GameObject buttn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void btnButton()
    {
        SceneManager.LoadScene("Levels");
        buttn.SetActive(true);

    }
    public void btnSlider()
    {
        SceneManager.LoadScene("Levels");
    }
}
