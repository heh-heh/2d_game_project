using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamestart_clear_button : MonoBehaviour
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
        gamemanager.demege = 3; gamemanager.score =0; gamemanager.exp = 0;
        SceneManager.LoadScene(scene_txt);
    }
}
