using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{

    
    public Slider hpvar;//hp바
    public Slider xp;//경험치 바

    public static float mxp = 50;

    public Text txt;

    // Start is called before the first frame update
    private void Start()
    {
        txt.text = gamemanager.nowHP + "  " +"/" + "  "+ gamemanager.maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        if(gamemanager.nowHP <= 0){
            gamemanager.diePlayer = true;//플레이어 죽음을 게임 매니져 한테 알림
        }
        transform.position = transform.position+new Vector3(0,0,0);

        hpvar.value = gamemanager.nowHP/gamemanager.maxHP;
        xp.value = gamemanager.exp/mxp;
        if(xp.value >= 1){
            gamemanager.level_UP=true;
            gamemanager.demege*=(float)1.15;
            gamemanager.exp -= mxp;
        }
        txt.text = gamemanager.nowHP + "/" + gamemanager.maxHP;
    }
}
