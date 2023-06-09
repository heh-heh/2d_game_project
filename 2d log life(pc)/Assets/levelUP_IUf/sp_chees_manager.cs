using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sp_chees_manager : MonoBehaviour
{
    public string[] sp_list;
    public static string[] sp_list_st;
    public static List<int> sp_list_num = new List<int>();
    public static bool level_UP2;
    public static bool chees_sp;
    public TextMeshProUGUI txt1;
    public TextMeshProUGUI txt2;
    public TextMeshProUGUI txt3;
    // Start is called before the first frame update
    void Start()
    {
        chees_sp = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(level_UP2==true&&chees_sp == false&&gamemanager.level_UP == true){
            sp_random(0,3,1,12);
            txt1.text = " "+sp_list[sp_list_num[0]];
            txt2.text = " "+sp_list[sp_list_num[1]];
            txt3.text = " "+sp_list[sp_list_num[2]];
            //Debug.Log("test" + sp_list_num[0] + sp_list_num[1] + sp_list_num[2]);
            chees_sp=true; level_UP2=false;
        }
    }
    void sp_random(int min, int max, int min2, int max2)
    {
        int currentNumber = Random.Range(min2, max2);
        for (int i = 0; i < max;)
        {
            if (sp_list_num.Contains(currentNumber))
            {
                currentNumber = Random.Range(min2, max2);
            }
            else
            {
                sp_list_num.Add(currentNumber);
                i++;
            }
        }
    }
}
