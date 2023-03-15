using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToiletSceneController : MonoBehaviour
{
    [SerializeField] CharacterController player;

    // Start is called before the first frame update
    private void Start()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        MainManager.Instance.SetSavedSceneIndex(currentSceneIndex);
        Debug.Log("SceneController > start > index = " + currentSceneIndex);

        MovePlayer();

        MainManager.Instance.ChangeVolume();
    }

    private void MovePlayer()
    {
        Vector3 playerPosition = MainManager.Instance.GetSavedPosition();
        Quaternion playerRotation = MainManager.Instance.GetSavedRotation();

        if (playerPosition != default(Vector3))
        {
            player.transform.localRotation = playerRotation;
            player.Move(playerPosition - player.transform.position);
        }
    }
}
