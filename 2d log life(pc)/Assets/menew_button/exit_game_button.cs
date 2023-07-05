using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit_game_button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void game_out(){
        SceneManager.LoadScene("menew");
        gamemanager.demege = 3; gamemanager.score =0; gamemanager.exp = 0;
        gamemanager.menew_sh = false;
    }
}
