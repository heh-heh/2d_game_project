using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class level_up_button : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void level_up_button_fn(){
        gamemanager.lvl+=1;
        player.mxp = player.mxp * (float)1.05;
        sp_chees_manager.chees_sp=false;
        gamemanager.level_UP = false;
    }
}
