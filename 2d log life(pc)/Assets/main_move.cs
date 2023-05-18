using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_move : MonoBehaviour
{
    public float movespeed = 3.0f;
    float movespeed2=0;

    float angle;
    Vector2 target, mouse;
    public Transform target2;
    //public Transform target;
    
    // Start is called before the first frame update
    void Start()
    {
        movespeed2=movespeed;
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        target_turn();
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
    void target_turn(){/*
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        angle = Mathf.Atan2(mouse.y - target.y, mouse.x - target.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.AngleAxis(angle-90, Vector3.forward);*/
        transform.LookAt(target2);
    }
}
