using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_move : MonoBehaviour
{

    public float movespeed = 3.0f;
    float movespeed2=0;

    float angle;
    public Transform target;
    Vector2 tg,tg2;

    public GameObject enemy;
    List<GameObject> findObj;


    private GameObject[] enemies;

    void Start()
    {
        movespeed += gamemanager.movespeed;
        movespeed2=movespeed;
        
    }
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        Move();
        //target_turn();
        GameObject closestEnemy = FindClosestEnemy();
        Vector3 direction = closestEnemy.transform.position - transform.position; // 플레이어에서 적까지의 방향 벡터
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; // 플레이어에서 적까지의 각도 계산
        transform.rotation = Quaternion.AngleAxis(angle-90, Vector3.forward); // 플레이어의 회전 조정

    }
    void Move(){
        float x=Input.GetAxisRaw("Horizontal");
        float y=Input.GetAxisRaw("Vertical");
        if(Input.GetKey(KeyCode.LeftShift)){
            movespeed=movespeed2*1.5f;
        }
        else movespeed=movespeed2;
        Vector3 moveVelocity = new Vector3(x,y,0)*movespeed*Time.deltaTime;


        this.transform.position += moveVelocity;
    }
    void target_turn(){
        target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        Vector3 look  = target.position - transform.position;
        float agl = Mathf.Atan2(look.y, look.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(agl-90, Vector3.forward);
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
