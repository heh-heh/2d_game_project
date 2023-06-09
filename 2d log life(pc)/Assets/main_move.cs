using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_move : MonoBehaviour
{

    static public float movespeed = 3.0f;
    float movespeed2=0;

    float angle;
    public Transform target;
    Vector2 tg,tg2;

    public GameObject enemy;
    List<GameObject> findObj;


    private GameObject[] enemies;

    void Start()
    {
        movespeed = gamemanager.movespeed;
        movespeed2=movespeed;
        
    }
    void Update()
    {
        
        movespeed += (gamemanager.movespeed*(float)(0.02 * gamemanager.sp_level[0]));

        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        Move();
        GameObject closestEnemy = FindClosestEnemy();
        Vector3 direction = closestEnemy.transform.position - transform.position; // 플레이어에서 적까지의 방향 벡터
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; // 플레이어에서 적까지의 각도 계산
        transform.rotation = Quaternion.AngleAxis(angle-90, Vector3.forward); // 플레이어의 회전 조정

    }
    void Move(){
        Vector3 moveVelocity;
        float x=Input.GetAxisRaw("Horizontal");
        float y=Input.GetAxisRaw("Vertical");
        if(Input.GetKey(KeyCode.LeftShift)){
            moveVelocity = new Vector3(x,y,0)*(float)(movespeed*1.5)*Time.deltaTime;
        }
        else moveVelocity = new Vector3(x,y,0)*movespeed*Time.deltaTime;
        
        this.transform.position += moveVelocity;
    }


    private GameObject FindClosestEnemy()
    {
        GameObject closestEnemy = null;
        float closestDistance = Mathf.Infinity;
        Vector3 playerPosition = transform.position;
        foreach (GameObject enemy in enemies)
        {
            float distance = Vector3.Distance(playerPosition, enemy.transform.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestEnemy = enemy;
            }
        }
        return closestEnemy;
    }
}
