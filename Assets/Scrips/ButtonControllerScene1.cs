using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControllerScene1 : MonoBehaviour
{
    string sceneName;
    string courseName;
    public GameObject canvasDialog;
    private System.Random randomActive = new System.Random();
    private void Awake()
    {
        
    }
    void Update()
    {

    }
    public void Onclick1()
    {
        int randomactive = randomActive.Next(2);
        if (randomactive == 0)
        {
            sceneName = "Scene2";
            courseName = " Chào mừng đến với khóa học Monkey ABC ";
            Debug.Log(courseName);
            SaveData();
            LoadNewScene();
        }
        else if(randomactive == 1)
        {
            EnablePanel(true);
        }
      
    }
    public void Onclick2()
    {
        Debug.Log("Đã chọn khóa học Monkey Stories");
    }
    public void Onclick3()
    {
        Debug.Log("Đã chọn khóa học Monkey Go");
    }
    public void Onclick4()
    {
        Debug.Log("Đã chọn khóa học Monkey Math");
    }
    public void OnClickDisablePanel()
    {
        EnablePanel(false);
    }
    public void LoadNewScene()
    {
        SceneManager.LoadScene(sceneName);
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
}

