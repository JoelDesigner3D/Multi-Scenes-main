using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{

    public static MainManager Instance;
    public float volume;

    // Used to respown in specific room of scene
    private Vector3 FPSPosition;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void GoToGeneralMenu()
    {
        GoTo("MenuGene");
    }

    public void GoTo(string sceneName)
    {

        int sceneIndex = 0;

        switch (sceneName)
        {
            case "WelcomeMenu":
                sceneIndex = 0;
                break;

            case "MenuGene":
                sceneIndex = 1;
                break;

            case "Cabin":
                sceneIndex = 2;
                break;

            case "Hospital":
                sceneIndex = 3;
                break;

            case "Morgue":
                sceneIndex = 4;
                break;

            case "Hospice":
                sceneIndex = 5;
                break;

            default:
                sceneIndex = 0;
                break;
        }

        SceneManager.LoadScene(sceneIndex);
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game ! By by");
        //Application.Quit();
        EditorApplication.ExecuteMenuItem("Edit/Play");

        // afficher message bon débarras !
    }

    public void SetFPSPosition(Vector3 fpsPosition)
    {
        if (fpsPosition != null)
        {
            FPSPosition = fpsPosition;
        }
    }

    public Vector3 GetFPSPosition()
    {
        return FPSPosition;
    }


}
