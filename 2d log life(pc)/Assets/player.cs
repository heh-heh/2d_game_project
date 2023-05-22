using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{


    public Slider hpvar;//hp바
    public Slider xp;//경험치 바

    public float exp = 0;
    public float mxp = 100;

    public float maxHP=100;
    public float nowHP;

    public Text txt;
    static public float demege = 0;
    

    // Start is called before the first frame update
    private void Start()
    {
        txt.text = nowHP + "  " +"/" + "  "+ maxHP;
        demege *= gamemanager.demegeup;
        maxHP *= gamemanager.maxhp;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(nowHP == 0){
            Destroy(gameObject);
        }
        transform.position = transform.position+new Vector3(0,0,0);

        hpvar.value = nowHP/maxHP;
        xp.value = exp/mxp;
        if(xp.value >= 1){
            exp = 0;
            mxp = mxp * (float)1.05;
        }
        txt.text = nowHP + "/" + maxHP;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy"){
            if(other.name == "big"){
                nowHP-=50;
            }
            else if(other.name == "zombi"){
                nowHP-=10; 
            }
            else if(other.name == "speed"){
                nowHP-=5;
            }
            else{
                nowHP=0;
            }
        }
    }

}
