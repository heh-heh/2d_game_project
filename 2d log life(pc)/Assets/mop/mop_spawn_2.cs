using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mop_spawn_2 : MonoBehaviour
{    
    public GameObject[] enemyPrefabs;
    public GameObject objectPrefab; // 생성할 오브젝트의 프리팹
    public Transform spawnArea;

    public float spawnInterval = 2f; // 생성 간격
    private float timer = 0f;


    // Start is called before the first frame update
    void Start()
    {
        spawnArea = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        spawnInterval = mop_spawn_menager.mop_spawn_time;
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            timer = 0f;
            if(Random.Range(1,4)==1)
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
