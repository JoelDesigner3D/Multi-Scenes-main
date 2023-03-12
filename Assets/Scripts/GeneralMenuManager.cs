using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralMenuManager : MonoBehaviour
{

    public float volume;

    public void GoToWelcomeMenu()
    {
       MainManager.Instance.GoTo("WelcomeMenu");
    }

    public void EnterToCabin()
    {
        Debug.Log("GoTo Cabin");
        MainManager.Instance.GoTo("Cabin");
    }

    public void EnterToCabinToilet()
    {
        //Debug.Log("GoTo Cabin");
        //MainManager.Instance.SetFPSLocation("Toilet");
        //MainManager.Instance.GoTo("Cabin");
        MainManager.Instance.GoTo("Cabin_Toilet");
    }

    public void EnterToHospital()
    {
        MainManager.Instance.GoTo("Hospital");
    }

    public void EnterToHospice()
    {
        MainManager.Instance.GoTo("Hospice");
    }

    public void EnterToMorgue()
    {
        MainManager.Instance.GoTo("Morgue");
    }

    public void QuitGame()
    {
       MainManager.Instance.QuitGame();
    }

}
