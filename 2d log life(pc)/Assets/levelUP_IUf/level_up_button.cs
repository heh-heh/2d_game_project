using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class level_up_button : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public int num=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = ""+sp_chees_manager.sp_list_st[num];
    }
    void level_up_button_fn(){
        gamemanager.lvl+=1;
        player.mxp = player.mxp * (float)1.05;
        gamemanager.level_UP = false;
    }
}
