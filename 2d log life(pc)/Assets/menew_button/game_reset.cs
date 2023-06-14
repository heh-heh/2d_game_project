using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_reset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void restart_game(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gamemanager.menew_sh=false;
    }
}
