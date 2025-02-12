using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearBehavior : MonoBehaviour
{
    private float nextFire = 10f;
    private float start = 0;
   
    void Start()
    {
        start = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - start > nextFire)
        {
            Destroy(gameObject);
        }
    }
}
