using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MainMenuDelay : MonoBehaviour
{
    public GameObject MenuButton;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MenuDelay());
    }

    IEnumerator MenuDelay()
    {
        yield return new WaitForSeconds(10);
        GameObject.Find("EventSystem").GetComponent<EventSystem>().SetSelectedGameObject(MenuButton, null);
        MenuButton.SetActive(true);
    }
    

}
