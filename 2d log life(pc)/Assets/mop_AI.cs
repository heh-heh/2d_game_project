using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mop_AI : MonoBehaviour
{
    float angle;
    int demege;
    public int maxhit = 10;
    Vector2 target2, target;
    public Transform player;
    public GameObject hp;
    public float movespeed = 2.0f;
    //public Imege Particle;

    void Start()
    {
        demege=0;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
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
            ///Play Particle;
            //ParticleSystem instance = Instantiate(explosionParticle, transform.position, Quaternion.identity);
            //instance.Play();
            //Destroy(instance.gameObject, instance.main.duration);
        
            //Take Damage
            //따로 구현필요
        
            //Set Active off
            Destroy(gameObject);
        }
        else if(other.tag == "bullet"){
            if(demege+1 == maxhit){
                gamemanager.exp += (maxhit/(float)2.2);
                Destroy(gameObject);
            }
            demege++;
        }
    }
}
