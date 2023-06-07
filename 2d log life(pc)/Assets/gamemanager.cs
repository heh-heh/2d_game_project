using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    public static bool menew_sh = false;


    //passve
    public static float gunspeed = 1;
    public static float movespeed = 0;
    public static float demegeup = 0;
    public static float cl = 1;
    public static float clde = 1;
    public static float maxhp = 0;
    public static bool diePlayer = false;
    public static float timeme=1.0f;
    public float timespeed = 1f;
    
    public static int lvl = 1;
    public Text lvtxt;

    public static float exp = 0;
    static public float demege = 3;
    static public float maxHP=50;
    static public float nowHP;
    
    // Start is called before the first frame update
    void Start()
    {
        lvtxt.text =" " + lvl;
        maxHP+=maxhp;
        nowHP=maxHP;
        demege+=demegeup;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(menew_sh == true){
            Time.timeScale =0;
        }
        else
            Time.timeScale=timespeed;//게임 배속 용
        if(diePlayer == true){//플레이어 사망
            Time.timeScale =0;
            
        }
        lvtxt.text = " " + lvl;
    }
}
