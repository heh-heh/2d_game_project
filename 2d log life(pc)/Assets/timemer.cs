using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timemer : MonoBehaviour
{
    public TextMeshProUGUI txt;
    int m, ss;
    static public float s;
    
    // Start is called before the first frame update
    void Start()
    {
        txt.text = "0.00";
        s=0.0f; m=0; ss=0;
    }

    // Update is called once per frame
    void Update()
    {
        if(ss == 30){gamemanager.game_clear = true;}

        s+=Time.deltaTime;
        ss=(int)s;
        if(ss>=60){m++; ss=0; gamemanager.timeme+=m; s=0;}
        txt.text = " " + m + " : " + ss;
    }
}
