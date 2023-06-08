using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sp_chees_manager : MonoBehaviour
{
    public string[] sp_list;
    public static string[] sp_list_st;
    public static List<int> sp_list_num = new List<int>();
    public static bool level_UP2=true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(gamemanager.level_UP==true && level_UP2==true){
            sp_random(1,3,12);
            for(int i=0; i<3; i++)sp_list_st[i] = sp_list[sp_list_num[i]];
            level_UP2 = false;
        }
    }

    void sp_random(int min, int max, int max2)
    {
        int currentNumber = Random.Range(min, max);
        for (int i = 0; i < max;)
        {
            if (sp_list_num.Contains(currentNumber))
            {
                currentNumber = Random.Range(min, max);
            }
            else
            {
                sp_list_num.Add(currentNumber);
                i++;
            }
        }
    }
}
