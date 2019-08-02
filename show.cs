using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show : MonoBehaviour {

	// Use this for initialization
	void Start () {
         if (transform.GetChild(1).GetComponent<TextMesh>().text== "")
          {
              gameObject.SetActive(false);
          }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
