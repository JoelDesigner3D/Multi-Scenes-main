using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SceneController : MonoBehaviour
{

    [SerializeField] GameObject toiletAnchor;

    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Awake()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        string playerLocation = MainManager.Instance.GetFPSLocation();

        if (playerLocation == "Toilet")
        {
            Debug.Log("playerLocation = " + playerLocation);
            player.transform.position = new Vector3(toiletAnchor.transform.position.x, player.transform.position.y, toiletAnchor.transform.position.z);
            MainManager.Instance.SetFPSLocation("");
        }
    }


}
