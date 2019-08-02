using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class quanbei : MonoBehaviour {
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    public void OnClick() {
        if (GameObject.Find("Canvas/Dropdown").GetComponent<Dropdown>().value != -1)
        {
            quit.j = ((char)(GameObject.Find("Canvas/Dropdown").GetComponent<Dropdown>().value + 97)).ToString();
            quit.i = 0;
            SceneManager.LoadScene("SampleScene");
        }

    }
}
