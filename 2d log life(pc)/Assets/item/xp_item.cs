using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xp_item : MonoBehaviour
{
    public int xp;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, item_spawn_meneger.item_live_time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            gamemanager.exp+=xp;
            Destroy(gameObject);
        }
    }
}
