using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideFire : MonoBehaviour
{


    public GameObject bulletFactory;
    public GameObject side1;
    public GameObject side2;
    public float firetime = 3.0f;
    float curTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    private void Fire()
    {
        curTime += Time.deltaTime;
        if(curTime>firetime)
        {
            curTime = 0.0f;
            GameObject bullet = Instantiate(bulletFactory);
            bullet.transform.position = transform.position;
        }
        
    }
}
