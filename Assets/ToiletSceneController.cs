using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToiletSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        MainManager.Instance.SetSavedSceneIndex(currentSceneIndex);
        Debug.Log("SceneController > start > index = " + currentSceneIndex);
    }
}
