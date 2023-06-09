using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_hp_recovery : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if(gamemanager.nowHP<gamemanager.maxHP)
                if(gamemanager.nowHP+(gamemanager.maxHP*(float)0.15)>gamemanager.maxHP)
                    gamemanager.nowHP = gamemanager.maxHP;
                else gamemanager.nowHP += (gamemanager.maxHP*(float)0.15);
            Destroy(gameObject);
        }
    }
}
