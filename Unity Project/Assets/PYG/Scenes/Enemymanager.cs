using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymanager : MonoBehaviour
{
    //에너미매니져 역할
    //에너미들을 찍어 낸다. (에너미 프리팹)
    //에너미 스폰타임 
    //에너미 스폰위치

    public GameObject enemyFactory; //에너미 공장
    public GameObject[] spawnPoint; //스폰위치
    //public GameObject[] spawnPoints; //스폰위치
    float spawnTime =1.0f ; //스폰타임 (몇초에 한번씩? )
    float curTime; // 누적 타임 
    //public Vector3 vec;

    // Update is called once per frame
    void Update()
    {
        //에너미 생성
        SpawnEnemy();
    }

    private void SpawnEnemy()
    {
        //몇초에 한번ㅆ기 이벤트 발동
        //시간 누적타임으로 계산한다.
        //게임에서 정말 자주 사용함

        curTime += Time.deltaTime;
        if(curTime>spawnTime)
        {
            curTime = 0.0f;
            spawnTime = Random.Range(0.5f,2.0f);
            //에너미 생성
            GameObject enemy = Instantiate(enemyFactory);
            // enemy.transform.position = spawnPoint.transform.position;
            int index = Random.Range(0, spawnPoint.Length);
           enemy.transform.position = transform.GetChild(index).transform.position;
           //enemy.transform.position = spawnPoints[index].
         }
    }
}
