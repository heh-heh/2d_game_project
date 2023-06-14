using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_shot : MonoBehaviour
{
    public GameObject bullet;//총알
    public Transform firePos;//총구\
    bool fire;

    // Start is called before the first frame update
    void Start()
    {
        fire = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(fire){   
            StartCoroutine("delay");
            Instantiate(bullet, firePos.transform.position, this.transform.rotation);
            fire = false;
        }
    }
        IEnumerator delay(){
        yield return new WaitForSeconds(gamemanager.firelate/1000);
        fire = true;
    }
}
