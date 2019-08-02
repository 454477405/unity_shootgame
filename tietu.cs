using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class tietu : MonoBehaviour {

    // Use this for initialization
     public Texture texture2;
	void Start () {
        string a = null;
        if (this.transform.name.Substring(4, 1) == ")")
            a = this.transform.name.Substring(3, 1);
        else
        {
            if (this.transform.name.Substring(5, 1) == ")")
                a = this.transform.name.Substring(3, 2);
            else
            {
                if (this.transform.name.Substring(6, 1) == ")")
                    a = this.transform.name.Substring(3, 3);
                else
                    Debug.LogError("超过1000了");
            }
        }
        //string str = @"C:\Users\yc\Desktop\考研\截图 - 副本\"+a+ ".png";
        string str = @"C:\Users\yc\Desktop\考研\截图 - 副本\1.png";

        FileStream fileStream = new FileStream(str, FileMode.Open, FileAccess.Read);
        // FileStream.Seek(0, SeekOrigin.Begin);
        byte[] bytes = new byte[fileStream.Length];
        fileStream.Read(bytes, 0, (int)fileStream.Length);
        fileStream.Close();
        fileStream.Dispose();
        fileStream = null;
        Texture2D texture1 = new Texture2D(1, 2);
        texture1.LoadImage(bytes);
        this.GetComponent<Renderer>().material.mainTexture = texture1;
        float scale=2;
        this.transform.localScale = new Vector3(texture1.width*scale,texture1.height*scale,2);
        transform.position = new Vector3(transform.position.x, texture1.height * scale / 2, transform.position.z);
  
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
