using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    
    public GameObject[] enemyPrefabs; // 다양한 적 프리팹들
    public float spawnInterval = 2f; // 생성 간격
    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
            if(Random.Range(1,10)==1)
                SpawnEnemy();

    }

    private void SpawnEnemy()
    {
        // 카메라 밖에서 랜덤한 종류의 적 생성
        Vector2 spawnPosition = GetRandomSpawnPosition();
        GameObject randomEnemyPrefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
        GameObject enemy = Instantiate(randomEnemyPrefab, spawnPosition, Quaternion.identity);
    }

    private Vector2 GetRandomSpawnPosition()
    {
        // 카메라의 왼쪽, 오른쪽, 위, 아래 중 하나에서 랜덤한 위치 반환
        float cameraHeight = mainCamera.orthographicSize;
        float cameraWidth = cameraHeight * mainCamera.aspect;

        float xSpawnOffset = Random.Range(0f, cameraWidth) * Random.Range(-1f, 1f);
        float ySpawnOffset = Random.Range(0f, cameraHeight) * Random.Range(-1f, 1f);

        Vector2 spawnPosition = new Vector2(xSpawnOffset, ySpawnOffset);
        return spawnPosition;
    }
}
