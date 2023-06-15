using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_shot_2 : MonoBehaviour
{
    public GameObject bullet;
    public Transform gunPos;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = gamemanager.firelate/1000;
    }

    // Update is called once per frame
    void Update()
    {
        timer-=Time.deltaTime;
        if(timer <= 0){
            SpawnBullet(); // 총알 발사
            timer = gamemanager.firelate/1000; // 타이머 초기화
        }
    }
    void SpawnBullet()
    {
        Instantiate(bullet, gunPos.position, gunPos.rotation);
    }
}