using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour
{
    public GameObject player;
    public Transform point;
    public float camera_speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = player.transform.position - this.transform.position;
    
        Vector3 move = new Vector3(dir.x * camera_speed *Time.deltaTime, dir.y * camera_speed *Time.deltaTime, 0.0f);
        this.transform.Translate(move);
    }
}
