using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;//用法三的时候需要定义这个
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class shitou : MonoBehaviour
{  
    public Texture texture;
    public Camera soliderCamera;
    public Rigidbody stone;
    public float power = 1600f;
    public float shootSpeed = 2;
    private float shootTime = 0;
    private float shootTimeInterval = 0;
    public static int hang = 0;
    public static string lujing0 = System.Environment.CurrentDirectory;
    public static string lujing = lujing0+ "\\txt\\";
    public static string lujing1 = lujing;
    public static string lujing2 =lujing+"buffer.txt";
    public static string lujing3 = lujing + "buffer - 副本.txt";
    void Start()
    {
        GameObject.Find("Canvas/Button").GetComponent<RectTransform>().position = new Vector3(20, Screen.height-20, 0);
        GameObject.Find("Canvas/Button (1)").GetComponent<RectTransform>().position = new Vector3(Screen.width - 20, Screen.height - 20, 0);
        lujing = lujing + quit.j+".txt";
        lujing1 = lujing1 + quit.j + " - 副本.txt";
        GameObject btnObj = GameObject.Find("Canvas/Button");
        Button btn = (Button)btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate () {
            onClick(); 
        });
        GameObject btnObj1 = GameObject.Find("Canvas/Button (1)");
        Button btn1 = (Button)btnObj1.GetComponent<Button>();
        btn1.onClick.AddListener(delegate () {
            onClick1();
        });
        string[] strs = File.ReadAllLines(lujing3);
        hang = strs.Length;
    }
    void onClick()
    {
        string[] str = File.ReadAllLines(lujing3);
        string[] str2 = File.ReadAllLines(lujing2);
        string[] str1=new string[str.Length - hang];
        string[] str3 = new string[str.Length - hang];
        for (int i = 0;i<str.Length-hang ; i++)
        { str1[i] = str[hang + i];
            str3[i] = str2[hang + i];
        }
        File.WriteAllLines(lujing3, str1);
        File.WriteAllLines(lujing2, str3);
        File.WriteAllText(shitou.lujing0 + "\\zi4mu3ji4yi4.txt", quit.j);
        lujing = lujing0 + "\\txt\\";
        SceneManager.LoadScene("New Scene");
    }
    void onClick1() {
        Application.Quit();
    }
    void Update() {
        if (Input.GetMouseButtonUp(0)){
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
    void FixedUpdate()
    {
        shootTime += 0.1f;
            thrower();                   
    }
    void thrower()
    {
        if (Input.GetKey(KeyCode.Mouse0)&& shootTime > shootTimeInterval)
        {
            shootTime = 0;       
            //Rigidbody instance = Instantiate(stone, transform.position, transform.rotation) as Rigidbody;
            Rigidbody instance = null ;
            Vector3 point = soliderCamera.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 0));
            Ray ray = soliderCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
            RaycastHit hitInfo;
           if (Physics.Raycast(ray, out hitInfo))
            {
                instance = Instantiate(stone, transform.position, transform.rotation) as Rigidbody;
                if (instance == null)
                    Debug.Log("空了");
                Vector3 fwd = hitInfo.point - point;
                Physics.IgnoreCollision(instance.GetComponent<Collider>(), this.GetComponent<Collider>());
                //Physics.IgnoreCollision(instance.GetComponent<Collider>(), instance.GetComponent<Collider>());
                instance.AddForce(power * fwd);
              //  instance.velocity = 20*fwd;
                Physics.IgnoreCollision(instance.GetComponent<Collider>(), this.GetComponent<Collider>());
            }
        }
    }
    void OnGUI()
{
       // if(GUI.RepeatButton(new Rect(10, 130, 70, 30), "hah")) {
         //   Debug.Log("sdf");
        //}
        Rect rect = new Rect(Input.mousePosition.x - (texture.width >> 1),//矩形的X轴坐标
        Screen.height - Screen.height / 2 - (texture.height >> 1),//矩形的y轴的坐标//
        texture.width,//矩形的宽
        texture.height);//矩形的高
    GUI.DrawTexture(rect, texture);//开始绘制       
    }
}