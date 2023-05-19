using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_move : MonoBehaviour
{
    public float movespeed = 3.0f;
    float movespeed2=0;

    float angle;
    public Transform target;
    //public Transform target;
    
    // Start is called before the first frame update
    void Start()
    {
        movespeed *= gamemanager.movespeed;
        movespeed2=movespeed;
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
    void target_turn(){
        Vector3 look  = target.position - transform.position;
        float agl = Mathf.Atan2(look.y, look.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(agl-90, Vector3.forward);
    }
}
