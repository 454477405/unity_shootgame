using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System;

public class text : MonoBehaviour {
	void Start () {
        string[] strs;
        if ( quit.i== 0) {
          strs = File.ReadAllLines(shitou.lujing);
        }

        else {
              strs = File.ReadAllLines(shitou.lujing2);//
        }
        string a = null;
        if (this.transform.parent.name.Substring(4, 1)== ")")
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
        if (Int32.Parse(a)  + Int32.Parse(b) - 1 <= strs.Length - 1)
            this.GetComponent<TextMesh>().text = strs[Int32.Parse(a)  + Int32.Parse(b) - 1];
        else
            this.GetComponent<TextMesh>().text = null;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
