using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class LabelDisplaying : MonoBehaviour
{
 
    [SerializeField] private GameObject infosCanvas;

    private TextMeshProUGUI canvasText;
    public TextMeshProUGUI labelText;
    private string text = "";


    void Start()
    {
        canvasText = infosCanvas.GetComponentInChildren<TextMeshProUGUI>();
        infosCanvas.SetActive(false);
       
    }


    private void OnMouseEnter()
    {
        Debug.Log("Mouse enter");
        infosCanvas.SetActive(true);

        Debug.Log(labelText.text);
        canvasText.text = labelText.text;
    }

    private void OnMouseExit()
    {
        Debug.Log("Mouse exit");
        infosCanvas.SetActive(false);
      //  canvasText.text = "";
    }

   

}
