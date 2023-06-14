using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_over : MonoBehaviour
{
    public GameObject game_over_UI;
    // Start is called before the first frame update
    void Start()
    {
        game_over_UI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(gamemanager.diePlayer == true){
            game_over_UI.SetActive(true);
        }
        else game_over_UI.SetActive(false);

        if(Input.GetKeyDown(KeyCode.Space) && gamemanager.diePlayer == true){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            gamemanager.diePlayer = false; gamemanager.nowHP=gamemanager.maxHP;
        }
    }
}
