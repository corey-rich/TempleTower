using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionMenu;

    public void ChangeToOptions()
    {
        optionMenu.SetActive(true);
        mainMenu.SetActive(false);
    }


}
