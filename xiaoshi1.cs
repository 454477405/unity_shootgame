using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
public class xiaoshi1 : MonoBehaviour
{
    void Start()
    {
        StreamWriter str1 = File.AppendText(shitou.lujing3);
        str1.WriteLine(this.GetComponent<TextMesh>().text);
        str1.Close();
        Destroy(this.gameObject, 3);
    }

    void Update()
    {
        
    }


}

