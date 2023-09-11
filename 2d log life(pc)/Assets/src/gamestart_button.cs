using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamestart_button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    static public void Change(string scene_txt){
        Debug.Log("scene Name to load  " + scene_txt);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gamemanager.game_clear[0]=false;
        SceneManager.LoadScene(scene_txt);
    }
}
