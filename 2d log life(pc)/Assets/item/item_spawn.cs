using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_spawn : MonoBehaviour
{    
    public GameObject[] enemyPrefabs;
    public Transform spawnArea;

    private float timer = 0f;


    // Start is called before the first frame update
    void Start()
    {
        spawnArea = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= mop_spawn_menager.mop_spawn_time)
        {
            timer = 0f;
            if(Random.Range(1,mop_spawn_menager.spawn_P)==1)
                SpawnObject();
        }
    }
    public void SpawnObject()
    {
        // 구역 내에서 랜덤한 위치 생성
        Vector3 spawnPosition = spawnArea.position + new Vector3(Random.Range(-spawnArea.localScale.x / 2f, spawnArea.localScale.x / 2f),
                                                                 Random.Range(-spawnArea.localScale.y / 2f, spawnArea.localScale.y / 2f),
                                                                 0f);
        // 오브젝트 생성
        GameObject randomEnemyPrefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
        GameObject enemy = Instantiate(randomEnemyPrefab, spawnPosition, Quaternion.identity);
    }
}
