using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class game_cl_UI : MonoBehaviour
{
    public GameObject sh_UI;
    public TextMeshProUGUI score_txt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gamemanager.game_clear[0] == true){
            score_txt.text = "점수 : "+gamemanager.score;
            sh_UI.SetActive(true);
        }
        else if(gamemanager.game_clear[0] == false){
            sh_UI.SetActive(false);
        }
    }
}
