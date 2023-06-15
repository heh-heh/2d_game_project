using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class test_UI : MonoBehaviour
{
    public TextMeshProUGUI demege_txt;
    public TextMeshProUGUI exp_txt;
    public TextMeshProUGUI speed_txt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        demege_txt.text = "demege : " + gamemanager.demege;
        exp_txt.text = "exp : " + gamemanager.exp;
        speed_txt.text = "speed : " + main_move.movespeed;
    }
}
