using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mop_AI : MonoBehaviour
{
    float angle;
    public float mophp;
    public float max_mophp;
    static public float demege = 10;
    Vector2 target2, target;
    public Transform player;
    public float movespeed = 2.0f;
    //public Slider hp;
    //public Imege Particle;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        max_mophp *= gamemanager.timeme*(float)1.1;
        mophp=max_mophp;
    }

    void Update()
    {
        //hp.value = mophp/max_mophp;

        //플레이어 따라 가기
        target2 = player.position;
        angle = Mathf.Atan2(target2.y - target.y, target2.x - target.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.AngleAxis(angle-90, Vector3.forward);
        transform.position = Vector3.MoveTowards(transform.position, player.position, movespeed*Time.deltaTime);

        if(gamemanager.game_clear[0] == true||gamemanager.game_clear[1] == true||gamemanager.game_clear[2] == true){Destroy(gameObject);}
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
                gamemanager.exp += (max_mophp/(float)2.2);
                gamemanager.score += (int)max_mophp * (int)gamemanager.timeme;
                Destroy(gameObject);
            }
            mophp -= gamemanager.demege;
        }
    }
}
