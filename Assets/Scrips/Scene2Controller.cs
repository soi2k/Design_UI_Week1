using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene2Controller : MonoBehaviour
{
    public Text recievedfrScene1 ;
    string textData;
    // Start is called before the first frame update
    void Start()
    {
        textData = PlayerPrefs.GetString("TextData", "Data ");
        recievedfrScene1.text = textData;
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
