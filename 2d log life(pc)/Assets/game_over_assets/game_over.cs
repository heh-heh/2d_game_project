using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class game_over : MonoBehaviour
{
    public GameObject game_over_UI;
    public TextMeshProUGUI score_txt;
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
            score_txt.text = "score : " + gamemanager.score;
        }
        else game_over_UI.SetActive(false);

        if(Input.GetKeyDown(KeyCode.Space) && gamemanager.diePlayer == true){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            gamemanager.diePlayer = false; gamemanager.nowHP=gamemanager.maxHP;
            gamemanager.exp = 0; gamemanager.score = 0;
        }
    }
}
