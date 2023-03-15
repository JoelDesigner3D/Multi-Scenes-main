using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneController : MonoBehaviour
{

    [SerializeField] GameObject welcomeMenu;
    [SerializeField] GameObject backMenu;

    
    void Start()
    {
        InitMenus();
        InitGame();
        //MainManager.Instance.InitGame();
    }

    private void InitMenus()
    {
        welcomeMenu.SetActive(false);
        backMenu.SetActive(false);
    }

    public void InitGame()
    {
        if (MainManager.Instance.newGame == true)
        {
            MainManager.Instance.LoadPlayerPrefs();
        }        

        int savedScene = MainManager.Instance.GetSavedSceneIndex();
        Debug.Log("MainSceneContreoller > InitGame  savedSceneIndex : " + savedScene);

        // MainMenu = 0, GeneralMenu index = 1
        if (savedScene > 1)
        {
            // SceneManager.LoadScene(savedSceneIndex);
            Debug.Log("Display BackMenu > savedSceneIndex = " + savedScene);
            DisplayBackMenu();
        }
        else
        {
            Debug.Log("Display WelcomeMenu");
            DisplayWelcomeMenu();
        }

    }

    public void DisplayWelcomeMenu()
    {
        Debug.Log("=========  WELCOME MENU ==========");
        InitMenus();
        //MainManager.Instance.SetSavedSceneIndex(0);
        //MainManager.Instance.SavePlayerPrefs();
        //SceneManager.LoadScene(0);
        welcomeMenu.SetActive(true);
    }

    public void DisplayBackMenu()
    {
        Debug.Log("=========  BACK MENU ==========");
        InitMenus();
        backMenu.SetActive(true);
    }

}
