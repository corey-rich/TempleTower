using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsToMainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionMenu;

    public void ChangeToOptions()
    {
        mainMenu.SetActive(true);
        optionMenu.SetActive(false);
    }
}
