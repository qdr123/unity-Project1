using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerfire : MonoBehaviour
{

    public GameObject bulletFactory; // 총알 프리팹 
    public GameObject firepoint;
    public GameObject side1;
    public GameObject side2;
    // Start is called before the first frame update
    void Start()
    {
       
    }


    // Update is called once per frame
    void Update()
    {
        Fire();
        side();
    }

    

    private void side()
    {
        if (!side1.activeSelf && !side2.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                side1.SetActive(true);
                side2.SetActive(true);
                Debug.Log("1");
            }

        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {

                side1.SetActive(false);
                side2.SetActive(false);

            }
        }
    }

    private void Fire()
    {
        //마우스왼쪽버튼 or 왼쪽컨트롤 키
        if(Input.GetButtonDown("Fire1"))
        {
            //총알공장(총알프리팹)에서 총알을 무한대로 찍어낼수 있다.
            //Instantiate() 함수로 프리팹 파일을 게임오브젝트로 만든다.

            GameObject bullet = Instantiate(bulletFactory);
            //총알 오브젝트의 위치 지정
            // bullet.transform.position = transform.position;
            bullet.transform.position = firepoint.transform.position;
        }
        
        
    }
}
