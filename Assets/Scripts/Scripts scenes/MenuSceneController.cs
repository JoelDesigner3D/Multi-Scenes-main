using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuSceneController : MonoBehaviour
{

    [SerializeField] Slider slider;

    private void Start()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("SceneController > start > index = " + currentSceneIndex);

        MainManager.Instance.ChangeVolume();

        slider.value = MainManager.Instance.GetVolume();
    }
}
