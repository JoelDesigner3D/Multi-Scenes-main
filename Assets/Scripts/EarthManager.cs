using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthManager : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0.05f, 0f));
    }
}
