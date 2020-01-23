using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhip : MonoBehaviour
{
    public float lifeTime;
    public Movement player;

    private void Start()
    {
        player = GetComponent<Movement>();
    }

    void Update()
    {
        if (lifeTime > 0)
        {
            lifeTime -= Time.deltaTime;
            if (lifeTime <= 0)
                Destroy(this.gameObject);
        }
    }
}
