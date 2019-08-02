using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class xiaoshi2 : MonoBehaviour
{
    void Start()
    {
        // GetComponent<Renderer>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision a)
    {
        //if (a.collider.name == "RigidBodyFPSController (1)"|| a.collider.name == "Sphere(Clone)")
        if (a.collider.name!=null&& a.collider.name!= "RigidBodyFPSController (1)"&& a.collider.name != "Sphere(Clone)")
        {
            Destroy(this.gameObject,1);
            //    GetComponent<Renderer>().enabled = false;
        }
    }


}