using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gamemanager : MonoBehaviour
{
    public static bool [] game_clear = new bool [3];


    public static bool menew_sh = false;
    public static bool level_UP = false;
    public bool stat_up = false;
    public static int[] sp_level;
    public int[] sp_level_public;

    //passve
    public static float gunspeed = 1;
    public static float movespeed = 3;
    public static float demegeup = 0;
    public static float cl = 1;
    public static float clde = 1;
    public static float maxhp = 0.05f;
    public static bool diePlayer = false;
    public static float timeme=1.0f;
    public float timespeed = 1f;
    public static float firelate_2 = 0.02f;
    public static float firelate = 0.1f;
    public float firelate_test = 0.1f;
    

    public static int lvl = 1;
    public TextMeshProUGUI lvl_txt;

    public static float exp = 0;
    static public float demege = 3;
    static public float maxHP=50;
    static public float nowHP;

    static public int score = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        lvl_txt.text =" " + lvl;
        nowHP=maxHP;
        demege=3;
        movespeed = 3;



    }

    // Update is called once per frame
    void Update()
    {
        
        if(menew_sh == true||level_UP == true||diePlayer == true||game_clear[0] == true||game_clear[1] == true||game_clear[2] == true){
            Time.timeScale =0;
        }
        else
            Time.timeScale=timespeed;//게임 배속 용
            
        if(stat_up == true){
            maxHP = maxHP+((maxHP*maxhp)*(sp_level[2]+1));
            stat_up = false;
        }
        lvl_txt.text = "" + lvl;
        firelate=firelate_test; sp_level=sp_level_public;
        
    }
}
