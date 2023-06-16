using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_spawn_meneger : MonoBehaviour
{
    public static float item_spawn_time;
    public static int spawn_P = 0;

    public float spawn_time = 0;
    public int spawn_p=0;
    public static int item_live_time = 0;
    public int item_live_time_public = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        item_live_time = item_live_time_public;
        item_spawn_time=spawn_time;
        spawn_P=spawn_p;
    }
}
