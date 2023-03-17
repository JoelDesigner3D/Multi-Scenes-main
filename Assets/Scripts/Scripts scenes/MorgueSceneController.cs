using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MorgueSceneController : MonoBehaviour
{
    [SerializeField] CharacterController player;

    private void Start()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (MainManager.Instance.newGame)
        {
            MovePlayer();
        }

        MainManager.Instance.SetSavedSceneIndex(currentSceneIndex);
        Debug.Log("SceneController > start > index = " + currentSceneIndex);

        MainManager.Instance.ChangeVolume();
    }

    private void MovePlayer()
    {
        Vector3 playerPosition = MainManager.Instance.GetSavedPosition();
        Quaternion playerRotation = MainManager.Instance.GetSavedRotation();
        Debug.Log("Before");
        Debug.Log("MovePlayer GetSavedPosition : " + JsonUtility.ToJson(playerPosition));
        Debug.Log("MovePlayer player position : " + JsonUtility.ToJson(player.transform.position));

        if (playerPosition != default(Vector3))
        {
            player.enabled = false;
            player.transform.position = playerPosition;
            player.enabled = true;
            //player.Move(playerPosition - player.transform.position);

            //Important : do rotation after moving
            player.transform.rotation = playerRotation;
        }

        Debug.Log("After");
        Debug.Log("MovePlayer GetSavedPosition : " + JsonUtility.ToJson(playerPosition));
        Debug.Log("MovePlayer player current position : " + JsonUtility.ToJson(player.transform.position));
    }
}
