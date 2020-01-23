/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whipAttack : MonoBehaviour
{


    public Movement script;
   
   
    void Update()
    {
        if (Input.GetAxis("Fire2") > 0)
            isWhipping = true;
        else
            isWhipping = false;

        if(counter<=21)
            counter++;

        if (counter > waitTime)
        {
            if (Input.GetMouseButton(0) || isWhip)
            {
                Instantiate(spawn, spawnPos.position, spawnPos.rotation);
                counter = 0;
            }
            
        }

    }

}*/
