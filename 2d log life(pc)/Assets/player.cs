using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{

    
    public Slider hpvar;//hp바
    public Slider xp;//경험치 바

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
            gamemanager.diePlayer = true;
        }
        transform.position = transform.position+new Vector3(0,0,0);

        hpvar.value = nowHP/maxHP;
        xp.value = gamemanager.exp/mxp;
        if(xp.value >= 1){
            gamemanager.exp = 0;
            gamemanager.lvl+=1;
            mxp = mxp * (float)1.05;
        }
        txt.text = nowHP + "/" + maxHP;
    }
}
