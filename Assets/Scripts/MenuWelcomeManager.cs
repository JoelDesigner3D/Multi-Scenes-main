using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MenuWelcomeManager : MonoBehaviour
{

    public void GoToGeneralMenu()
    {
        MainManager.Instance.GoTo("MenuGene");
    }

    public void EnterToCabin()
    {
        MainManager.Instance.GoTo("Cabin");
    }

    public void QuitGame()
    {
        MainManager.Instance.QuitGame();
    }

}
