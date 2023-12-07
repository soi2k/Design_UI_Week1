using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene2Controller : MonoBehaviour
{
    public Text recievedfrScene1 ;
    
    // Start is called before the first frame update
    void Start()
    {
        recievedfrScene1.text = PlayerPrefs.GetString("TextDataScene1"); ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackToScene1()
    {
        SceneManager.LoadScene("Scene1");
    }
}
