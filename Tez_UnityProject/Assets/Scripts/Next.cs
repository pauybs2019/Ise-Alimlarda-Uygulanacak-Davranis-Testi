using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Next : MonoBehaviour
{
    public GameObject Panel, Panel2;
    public GameObject nextButton, previousButton;

    public void NextScene()
    {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;

            SceneManager.LoadScene(sceneIndex+1);
    }

    public void mainMenu ()
    {
        SceneManager.LoadScene(0);
    }

    public void changePanel()
    {
        bool panelActive = Panel.activeSelf;
        bool panel2Active = Panel2.activeSelf;

        if (Panel != null && Panel2 != null)
        {
            Panel.SetActive(!panelActive);
            Panel2.SetActive(!panel2Active);
            
        }
    }
}
