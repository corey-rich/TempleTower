using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpin : MonoBehaviour
{
    public int speed;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Time.deltaTime * speed, 0, 0);
    }
}
