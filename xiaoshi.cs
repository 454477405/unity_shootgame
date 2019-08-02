using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
public class xiaoshi : MonoBehaviour {
    int i = 0;
    void Start () {
    }

	void Update () {
    
       }
    [Obsolete]
    private void OnCollisionEnter(Collision a)
    {
        i++;
        StreamWriter str1 = File.AppendText(shitou.lujing2);        
        string aa = null;
        if (a.collider.name == "Sphere 2(Clone)")
        {
            if (i == 1)
            {//避免同时碰撞带来的多次写。
                str1.WriteLine(this.GetComponent<TextMesh>().text);
            }
            aa = name + " (1)";
            transform.parent.FindChild(aa).gameObject.SetActive(true);
            Destroy(this.gameObject);
        }
        str1.Close();
    }
}

