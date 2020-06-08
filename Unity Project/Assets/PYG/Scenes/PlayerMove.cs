using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5.0f; //플레이어 이동속도
    public Vector2 margin; // 뷰포트좌표는 0.0~0.1f 사이 

    //조이스틱 사용하기
    public VariableJoystick joystick;
    public Camera cam;
    void Start()
    {
        margin = new Vector2(0.08f, 0.05f);  
    }

    // Update is called once per frame
    void Update()
    {
        Move();    
    }


    //플레이어 이동
    private void Move()
    {
          

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
       
        
        //조이스틱 사용하기 
        //키보드가 안눌렸을때 => 조이스틱 사용하면 된다.
        if(h == 0 && v == 0)
        {
            h = joystick.Horizontal;
            v = joystick.Vertical;
        }
        
        
        //transform.Translate(h * speed * Time.deltaTime, v * speed * Time.deltaTime, 0);
        //Vector3 dir = Vector3.right * h + Vector3.up * v;  // =  
        Vector3 dir = new Vector3(h, v, 0);
        //dir.Normalized();
        transform.Translate(dir * speed * Time.deltaTime);
       
        

      if(transform.position.x>=2.3f)
        {
            Vector3 vector;
            vector = transform.position;
            vector.x = 2.3f;
            transform.position = vector;
        }
      if(transform.position.x<=-2.3f)
        {
            Vector3 vector;
            vector = transform.position;
            vector.x = -2.3f;
            transform.position = vector;
        }
      if(transform.position.y>=9.5f)
        {
            Vector3 vector;
            vector = transform.position;
            vector.y = 9.5f;
            transform.position = vector;
        }
      if(transform.position.y<=0.4f)
        {
            Vector3 vector;
            vector = transform.position;
            vector.y = 0.4f;
            transform.position = vector;
        }


        //Mathf.Clamp(vector.x ,최소값,최대값);
        // Vector.X = Mathf.Clamp(Vector.X, -2.5f, 2.5f);



        //위치 = 현재위치 +(방향*시간)
        //p= P0+vt;
        //transform.position = transform.position + (dir * speed * Time.deltaTime);
        //transform.position += dir + speed * Time.deltaTime;


        //3. 메인카메라의 뷰포트를 가져와서 처리한다.
        //스크린좌표 : 왼쪽하단0,0  우측상담 maxX,maxY
        //뷰포트좌표 : 왼쪽하단 0,0 우측상단 1.0f,1.0f
        //Vector3 position = Camera.main.WorldToViewportPoint(transform.position);
        //position.x = Mathf.Clamp(position.x,0.0f+margin.x,1.0f-margin.x);
        //position.y = Mathf.Clamp(position.y,0.0f+margin.y,1.0f-margin.y);
        //transform.position = Camera.main.WorldToScreenPoint(transform.position);

    }
}
