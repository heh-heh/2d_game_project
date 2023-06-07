using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class retunr_EXP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void reuturn_exp()
    {
        gamemanager.lvl --;
        gamemanager.exp = player.mxp*(float)0.2;
        gamemanager.level_UP = false;
    }
}
