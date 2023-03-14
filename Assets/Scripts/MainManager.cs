using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor;
using UnityEngine.SceneManagement;

//[DefaultExecutionOrder(1000)]
public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    private float volume;
    private Vector3 savedPosition;
    private Quaternion savedRotation;
    private int savedSceneIndex;

    public bool newGame = true;

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

    private void Start()
    {
        Debug.Log("=========  NEW GAME ==========");
        //Debug.Log("MainManager > start activeScene = " + SceneManager.GetActiveScene().buildIndex);
        //Debug.Log("MainManager > start savedScene = " + savedSceneIndex);
        //InitGame();
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

        newGame = false;
        SceneManager.LoadScene(sceneIndex);
       
    }
    
    public void QuitGame()
    {
       // Debug.Log("MainManager > QuitGame savedSceneIndex = "+ this.savedSceneIndex);

        SavePlayerPrefs();

        //Application.Quit();
        EditorApplication.ExecuteMenuItem("Edit/Play");

        //TODO afficher message bon d�barras !
    }

    /*
    public void InitGame()
    {
        Debug.Log("MainManager > InitGame  savedSceneIndex : "+ savedSceneIndex);

        LoadPlayerPrefs();

        if (savedSceneIndex > 1)
        {
            // SceneManager.LoadScene(savedSceneIndex);
            Debug.Log("Display BackMenu > savedSceneIndex = "+ savedSceneIndex);
            mainSceneController.displayBackMenu();
        }
        else
        {
            Debug.Log("Display WelcomeMenu");
            mainSceneController.displayWelcomeMenu();
        }
        
    }
    */

    public void GoToSceneByIndex(int index)
    {
        SceneManager.LoadScene(index);
    }


    public void SavePlayerPrefs()
    {

        Debug.Log("=========  SAVE PREFS ==========");
        Debug.Log("savedSceneIndex : "+ this.GetSavedSceneIndex());

        PlayerPrefs.SetFloat("MainVolume", this.GetVolume());

        PlayerPrefs.SetInt("SceneIndex", this.GetSavedSceneIndex());

        string playerPosition = JsonUtility.ToJson(this.GetSavedPosition());
        PlayerPrefs.SetString("FPSPosition", playerPosition);

        string playerRotation = JsonUtility.ToJson(this.GetSavedRotation());
        PlayerPrefs.SetString("FPSRotation", playerPosition);

        PlayerPrefs.Save();
    }

    public void LoadPlayerPrefs()
    {
        Debug.Log("=========  LOAD PREFS ==========");
        

        int sceneIndex = PlayerPrefs.GetInt("SceneIndex");
        this.SetSavedSceneIndex(sceneIndex);
        Debug.Log("savedSceneIndex : " + this.GetSavedSceneIndex());

        Vector3 playerPosition = JsonUtility.FromJson<Vector3>(PlayerPrefs.GetString("FPSPosition"));
        this.SetSavedPosition(playerPosition);

        Quaternion playerRotation = JsonUtility.FromJson<Quaternion>(PlayerPrefs.GetString("FPSRotation"));
        this.SetSavedRotation(playerRotation);

        float mainVolume = PlayerPrefs.GetFloat("MainVolume");
        this.SetVolume(mainVolume);
    }


    /*
     * ===================================
     *          GETTERS / SETTERS
     * ===================================
     * 
     */


    public void SetSavedPosition(Vector3 _savedPosition)
    {
        if (_savedPosition != default(Vector3))
        {
            savedPosition = _savedPosition;
        }
    }

    public Vector3 GetSavedPosition()
    {
        return savedPosition;
    }

    public void SetSavedRotation(Quaternion _savedRotation)
    {
        if (_savedRotation != default(Quaternion))
        {
            savedRotation = _savedRotation;
        }
    }

    public Quaternion GetSavedRotation()
    {
        return savedRotation;
    }

    public void SetSavedSceneIndex(int _savedSceneIndex)
    {
        savedSceneIndex = _savedSceneIndex;
    }

    public int GetSavedSceneIndex()
    {
        return savedSceneIndex;
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
