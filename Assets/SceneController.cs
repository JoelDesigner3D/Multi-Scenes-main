using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    [SerializeField] GameObject toiletAnchor;
    [SerializeField] GameObject FPS;


    // Start is called before the first frame update
    void Awake()
    {
        //MovePlayer();
    }

    private void Start()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        MainManager.Instance.SetSavedSceneIndex(currentSceneIndex);
        Debug.Log("SceneController > start > index = " + currentSceneIndex);
    }

    private void MovePlayer()
    {
        //Vector3 initPosition = MainManager.Instance.GetSavedPosition();
        //Quaternion initRotation = MainManager.Instance.GetSavedRotation();

        Vector3 initPosition = toiletAnchor.transform.position;
        Quaternion initRotation = toiletAnchor.transform.rotation;

        if (initPosition != default(Vector3))
        {
            FPS.transform.localPosition = initPosition;
            FPS.transform.localRotation = initRotation;
        }
        //string playerLocation = MainManager.Instance.GetFPSLocation();

        // if (playerLocation == "Toilet")
        // {
        // Debug.Log("playerLocation = " + playerLocation);
        // Debug.Log("SceneController > Awake > MovePlayer");
        // FPS.transform.position = new Vector3(toiletAnchor.transform.position.x, FPS.transform.position.y, toiletAnchor.transform.position.z);
        //MainManager.Instance.SetFPSLocation("");
        // }
    }


}
