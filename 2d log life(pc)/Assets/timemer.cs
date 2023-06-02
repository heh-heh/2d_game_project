using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timemer : MonoBehaviour
{
    public TextMeshProUGUI txt;
    float timeme=0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        txt.text = "0.00";
    }

    // Update is called once per frame
    void Update()
    {
        timeme+=Time.deltaTime;
        txt.text = " "+timeme;
    }
}
