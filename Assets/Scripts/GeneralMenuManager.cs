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
        MainManager.Instance.GoTo("Cabin");
    }

    public void EnterToCabinToilet()
    {
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

}
