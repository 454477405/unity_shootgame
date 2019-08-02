using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ok : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnClick()
    {
        string str11 = shitou.lujing;
        string str = GameObject.Find("Canvas/InputField (1)/Text").GetComponent<Text>().text;
        int i = 0;
        string[] strs = File.ReadAllLines(str11 + str + " - 副本.txt");
        //Debug.Log(str11 + str22 + " - 副本.txt");
        string[] str1 = new string[strs.Length];
        int ii = 0;
        while (ii < strs.Length)
        {
            for (i = 0; i < strs[ii].Length; i++)
            {
                if ((strs[ii].Substring(i, 1)[0] < 97 || strs[ii].Substring(i, 1)[0] > 122)
                    && (strs[ii].Substring(i, 1)[0] > 90 || strs[ii].Substring(i, 1)[0] < 65) || i == strs[ii].Length - 1)
                {
                    for (int j = 0; j < i; j++)
                        str1[ii] = strs[ii].Substring(0, i);
                    break;
                }

            }
            ii++;
        }
        File.WriteAllLines(str11 + str + ".txt", str1);
    }
}
