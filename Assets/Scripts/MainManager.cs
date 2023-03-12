using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{

    public static MainManager Instance;
    [SerializeField] private float volume;

    // Used to respown in specific room of scene
    private string FPSLocation = "";

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

            case "Cabin_Toilet":
                sceneIndex = 6;
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

    /*
     * ===================================
     *          GETTERS / SETTERS
     * ===================================
     * 
     */

    public void SetFPSLocation(string fpsLocation)
    {
        if (fpsLocation != "")
        {
            FPSLocation = fpsLocation;
        }
    }

    public string GetFPSLocation()
    {
        return FPSLocation;
    }

    public void SetVolume(float _volume)
    {
        if (_volume < 0)
        {
            _volume = 0;
        }

        this.volume = _volume;
    }

    public float GetVolume()
    {
        return volume;
    }


}
