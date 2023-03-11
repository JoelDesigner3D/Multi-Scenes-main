using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureManagement : MonoBehaviour
{

    public GameObject sprite;
    public GameObject frame;
    public GameObject border;

    private float rotationY;

    // Start is called before the first frame update
    void Start()
    {


        float posX = sprite.transform.localPosition.x;
        float posY = sprite.transform.localPosition.y;
        float posZ = sprite.transform.localPosition.z;

        // Set frame size from picture size
        frame.transform.localScale = sprite.GetComponent<Renderer>().localBounds.size * 1.05f;
        frame.transform.localScale = new Vector3(frame.transform.localScale.x, frame.transform.localScale.y, 0.02f);
        frame.transform.localPosition = new Vector3(posX, posY, posZ + 0.02f);

        // Set border size from picture size
        border.transform.localScale = sprite.GetComponent<Renderer>().localBounds.size * 1.08f;
        border.transform.localScale = new Vector3(border.transform.localScale.x, border.transform.localScale.y, 0.04f);
        border.transform.localPosition = new Vector3(posX, posY, posZ + 0.04f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
