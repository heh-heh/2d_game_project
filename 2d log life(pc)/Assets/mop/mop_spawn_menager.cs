using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mop_spawn_menager : MonoBehaviour
{
    public static float mop_spawn_time;
    public static int spawn_P = 0;

    public float spawn_time = 0;
    public int spawn_p=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mop_spawn_time=spawn_time;
        spawn_P=spawn_p;
    }
}
