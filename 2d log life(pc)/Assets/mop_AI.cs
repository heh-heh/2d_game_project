using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mop_AI : MonoBehaviour
{
    float angle;
    public float mophp;
    public float max_mophp;
    static public float demege = 10;
    Vector2 target2, target;
    public Transform player;
    public float movespeed = 2.0f;
    //public Imege Particle;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        max_mophp *= gamemanager.timeme*(float)1.1;
        mophp=max_mophp;
    }

    void Update()
    {
        //플레이어 따라 가기
        target2 = player.position;
        angle = Mathf.Atan2(target2.y - target.y, target2.x - target.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.AngleAxis(angle-90, Vector3.forward);
        transform.position = Vector3.MoveTowards(transform.position, player.position, movespeed*Time.deltaTime);
    }
        private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            gamemanager.nowHP -= demege;
            Destroy(gameObject);
        }
        else if(other.tag == "bullet"){
            if(mophp <= 0 ){
                gamemanager.exp += (mophp/(float)2.2);
                Destroy(gameObject);
            }
            mophp -= gamemanager.demege;
        }
    }
}
