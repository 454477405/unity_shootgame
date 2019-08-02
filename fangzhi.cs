using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class fangzhi : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.Find("Canvas/Button").GetComponent<RectTransform>().position = new Vector3(Screen.width, Screen.height, 0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
