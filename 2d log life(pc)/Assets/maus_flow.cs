using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maus_flow : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    Vector3 mousePos, transPos, targetPos;
    public Transform player; 
    public float range = 10.0f;

    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        CalTargetPos();
        MoveToTarget();
        
    }

    void CalTargetPos()
    {
        mousePos = Input.mousePosition;
        transPos = Camera.main.ScreenToWorldPoint(mousePos);
        targetPos = new Vector3(transPos.x, transPos.y, 0);
    }

    void MoveToTarget()
    {
        //float distance = Vector2.Distance(transform.position, player.position);
        //if(distance <  range)
        transform.position = Vector3.MoveTowards(transform.position, targetPos, Time.deltaTime * speed);
        
    }
}