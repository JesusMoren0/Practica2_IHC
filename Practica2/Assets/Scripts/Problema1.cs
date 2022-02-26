using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i,j,indi;
        int[] num = new int[]{4,9,8,1,2,7};
        int[]t;
        t = Array(num.Length);
        for(i = 0; x < num.Length ; i++)
        {
            indi = num[i];
            for(j = 0; j<num.Length; j++)
            {
                if(indi > num[j])
                {
                    t[i]++;
                }
            }
        }
        for(i = 0; i<6; i++)
        {
            Debug.Log(t[i]);
        }
    }

    // Update is called once per frame
    int[]Array(int n)
    {
        int i;
        int[]arg = new int[n];
        for(i = 0; i < n; i++)
        {
            arg[i] = 0;
        }
        return arg;
    }
}
