using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class jianbei : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnClick() {
        quit.i = 1;
        SceneManager.LoadScene("SampleScene");
    }
}
