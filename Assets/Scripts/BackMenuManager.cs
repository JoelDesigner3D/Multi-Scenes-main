using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMenuManager : MonoBehaviour
{
    [SerializeField] MainSceneController mainSceneController;

    public void GoToSavedScene()
    {
        int index = MainManager.Instance.GetSavedSceneIndex();
        MainManager.Instance.GoToSceneByIndex(index);
        MainManager.Instance.SetSavedSceneIndex(0);
    }
    
    public void DisplayWelcomeMenu()
    {
        //init player prefs
        MainManager.Instance.SetSavedSceneIndex(0);
        MainManager.Instance.SetSavedPosition(default(Vector3));
        MainManager.Instance.SetSavedRotation(default(Quaternion));

        mainSceneController.DisplayWelcomeMenu();
    }
    
    public void QuitGame()
    {
        MainManager.Instance.QuitGame();
    }
}
