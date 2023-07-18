using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_stat : MonoBehaviour
{
    protected float hp;
    protected float now_hp;
    protected float exp;
    protected float speed;
    protected float fire_late; // 현 발사 속도
    float fire_late2; //계산용
    // Start is called before the first frame update
    void Start()
    {   
        fire_late2 = fire_late;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
