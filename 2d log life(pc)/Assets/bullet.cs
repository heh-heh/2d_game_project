using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{   
    // Start is called before the first frame update
    public float bulletSpeed = 0.01f;
    public float bulletDemege = 10.0f;
    public float lefetime = 0f;
    private Rigidbody2D rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lefetime);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector2( transform.position.x+1*bulletSpeed,0);
        rigid.velocity = transform.up * bulletSpeed;


        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            //Play Particle
            //ParticleSystem instance = Instantiate(explosionParticle, transform.position, Quaternion.identity);
            //instance.Play();
            //Destroy(instance.gameObject, instance.main.duration);
        
            //Take Damage
            //따로 구현필요
        
            //Set Active off
            Destroy(gameObject);
        }
    }

}
