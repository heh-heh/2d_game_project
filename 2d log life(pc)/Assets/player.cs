using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public GameObject bullet;//총알
    public Transform firePos;//총구
    public Slider hpvar;
    public float maxHP=100;
    public float nowHP;
    public Text txt;
    public float firelate = 0.1f;
    bool fire;

    // Start is called before the first frame update
    private void Start()
    {
        txt.text = nowHP + " / " + maxHP;
        fire = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)&&fire == true){
            StartCoroutine("delay");
            Instantiate(bullet, firePos.transform.position, this.transform.rotation);
            fire = false;
        }
        transform.position = transform.position+new Vector3(0,0,0);
        hpvar.value = nowHP/maxHP;
        txt.text = nowHP + "/" + maxHP;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy"){
            nowHP -= 10;
        }
    }
    IEnumerator delay(){
        yield return new WaitForSeconds(firelate);
        fire = true;
    }
}
