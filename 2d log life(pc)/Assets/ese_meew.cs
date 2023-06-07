using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ese_meew : MonoBehaviour
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
        if(Input.GetKeyDown(KeyCode.Escape)&&gamemanager.menew_sh==false){
            sh_UI.SetActive(true);
            gamemanager.menew_sh=true;
        }
        else if(Input.GetKeyDown(KeyCode.Escape)&&gamemanager.menew_sh==true){
            sh_UI.SetActive(false);
            gamemanager.menew_sh=false;
        }
    }
}
