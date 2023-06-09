using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXP_UI_SH : MonoBehaviour
{
    public GameObject sh_UI;
    // Start is called before the first frame update
    void Start()
    {
        sh_UI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(gamemanager.level_UP == true){
            sp_chees_manager.level_UP2=true;
            sh_UI.SetActive(true);
        }
        else if(gamemanager.level_UP == false){
            sh_UI.SetActive(false);
        }
    }
}
