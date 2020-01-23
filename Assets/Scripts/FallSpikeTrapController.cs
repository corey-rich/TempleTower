using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallSpikeTrapController : MonoBehaviour
{
    public Animator anim;
    public float waitTime;
    private bool reload = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player" && reload == true)
        {
        reload = false;
        anim.Play("FallSpikeTrapGoDown"); 
        StartCoroutine(Wait());
        }       
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);
        // moves down
        reload = true;
    }
}
