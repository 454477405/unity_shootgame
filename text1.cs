using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System;

public class text1 : MonoBehaviour
{

    void Start()
    {
        string[] strs;
        if (quit.i == 0)
        {
            strs = File.ReadAllLines(shitou.lujing1);
        }
        else
        {
            strs = File.ReadAllLines(shitou.lujing3);
        }

        string a = null;
        if (this.transform.parent.name.Substring(4, 1) == ")")
            a = this.transform.parent.name.Substring(3, 1);
        else
        {
            if (this.transform.parent.name.Substring(5, 1) == ")")
                a = this.transform.parent.name.Substring(3, 2);
            else
            {
                if (this.transform.parent.name.Substring(6, 1) == ")")
                    a = this.transform.parent.name.Substring(3, 3);
                else
                    Debug.LogError("超过1000了");
            }
        }
        string b = this.name;
        this.GetComponent<TextMesh>().text = strs[Int32.Parse(a) * 1 + b[0] -49];
        //Debug.Log(b[0]+1-50);
    }

    // Update is called once per frame
    void Update()
    {

    }
}


