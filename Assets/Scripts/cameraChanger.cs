using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraChanger : MonoBehaviour
{
    public GameObject cameralogo;
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;
    public GameObject camera5;
    public GameObject camera6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            cameralogo.SetActive(false);
            camera1.SetActive(true);
        }
        if (Input.GetKeyDown("2"))
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
        if (Input.GetKeyDown("3"))
        {
            camera2.SetActive(false);
            camera3.SetActive(true);
        }
        if (Input.GetKeyDown("4"))
        {
            camera3.SetActive(false);
            camera4.SetActive(true);
        }
        if (Input.GetKeyDown("5"))
        {
            camera4.SetActive(false);
            camera5.SetActive(true);
        }
        if (Input.GetKeyDown("6"))
        {
            camera5.SetActive(false);
            camera6.SetActive(true);
        }
    }
}
