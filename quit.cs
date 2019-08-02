using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
public class quit : MonoBehaviour {

    // Use this for initialization
    public static string j;
    public static int i = 0;
    void Start () {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        GameObject.Find("Canvas/Button (4)").GetComponent<RectTransform>().position = new Vector3(Screen.width - 20, Screen.height - 20, 0);
        Dropdown d = GameObject.Find("Canvas/Dropdown").GetComponent<Dropdown>();
        d.options.Clear();
        Dropdown.OptionData temoData; 
        for (int i = 0; i < 26; i++)
        {
            //给每一个option选项赋值
             temoData = new Dropdown.OptionData();
            temoData.text = ((char)(i + 97)).ToString();
            d.options.Add(temoData);
        }
        string str=File.ReadAllText(shitou.lujing0+ "\\zi4mu3ji4yi4.txt");
        GameObject.Find("Dropdown").GetComponent<Dropdown>().value = str.ToCharArray()[0]-97;
    }
    // Update is called once per frame
    void Update () {
		
	}
    public void Onclick() {
        File.WriteAllText(shitou.lujing0 + "\\zi4mu3ji4yi4.txt", quit.j);
        Application.Quit();
    }
    void xixi()
    {
        string[] strs = File.ReadAllLines(shitou.lujing+"chuli - 副本.txt");
        string[] strs1 = File.ReadAllLines(shitou.lujing + "chuli.txt");
        string[] strs2 = new string[strs.Length];
        for (int i = 0; i < strs.Length; i++)
        {
            strs2[i] = strs1[i] + " " + strs[i];
        }
        //System.Text.Encoding.GetEncoding(strs2[0]);
        File.WriteAllLines(shitou.lujing + "chuli1.txt", strs2);
    }

}
