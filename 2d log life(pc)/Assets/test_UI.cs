using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class test_UI : MonoBehaviour
{
    public TextMeshProUGUI demege_txt;
    public TextMeshProUGUI exp_txt;
    public TextMeshProUGUI speed_txt;
    public TextMeshProUGUI score_txt;
    public TextMeshProUGUI fire_txt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        demege_txt.text = "demege : " + gamemanager.demege;
        exp_txt.text = "exp : " + gamemanager.exp;
        speed_txt.text = "speed : " + gamemanager.movespeed;
        score_txt.text = "score : " + gamemanager.score;
        fire_txt.text = "fire rate : " + (gamemanager.firelate - (gamemanager.firelate* (gamemanager.firelate_2*gamemanager.sp_level[3])));
    }
}
