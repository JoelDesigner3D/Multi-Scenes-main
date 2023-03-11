using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeDestinationScript : MonoBehaviour
{

    [SerializeField] int sceneIndex;


    public void GoToDestination(int sceneIndex, Vector3 position)
    {
        if (position == null)
        {
            position = new Vector3(0, 0, 0);
        }

        SceneManager.LoadScene(sceneIndex);
    }

}
