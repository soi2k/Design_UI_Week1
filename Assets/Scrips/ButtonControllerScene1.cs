using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonControllerScene1 : MonoBehaviour
{
    string sceneName;
    string courseName;
    public GameObject canvasDialog;
    private System.Random randomActive = new System.Random();
    private int randomactive;
    [SerializeField] private Text textCourseName;
    private void Awake()
    {
        
    }
    void Update()
    {
        randomactive = randomActive.Next(2);
    }
    public void Onclick1()
    {
        if (randomactive == 0)
        {   
            SoundController.ButtonSound.ButtonPlaySound("wing", 1);
            sceneName = "Scene2";
            courseName = textCourseName.text;
            SaveData();
            StartCoroutine(DelayLoadScene());
        }
        else if(randomactive == 1)
        {
            SoundController.ButtonSound.ButtonPlaySound("swoosh", 1);
            EnablePanel(true);
        }
      
    }
    
    public void OnClickDisablePanel()
    {
        SoundController.ButtonSound.ButtonPlaySound("close", 0.7f);
        EnablePanel(false);
    }
  

    private void SaveData()
    {
        PlayerPrefs.SetString("TextDataScene1", courseName);
        PlayerPrefs.Save();
    }
    private void EnablePanel(bool blactive)
    {
        canvasDialog.SetActive(blactive);
    }  

    private IEnumerator DelayLoadScene()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(sceneName);
    }
}

