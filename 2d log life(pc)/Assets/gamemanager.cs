using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    //passve
    public static float gunspeed = 1;
    public static float movespeed = 1;
    public static float demegeup = 1;
    public static float cl = 1;
    public static float clde = 1;
    public static float maxhp = 1;
    public static bool diePlayer = false;
    public static int lvl = 1;
    public Text lvtxt;

    public static float exp = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        lvtxt.text =" " + lvl;
    }

    // Update is called once per frame
    void Update()
    {
        lvtxt.text = " " + lvl;
    }
}
