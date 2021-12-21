using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject camera_movement;
    Vector3 camera_Set;
    // Start is called before the first frame update


    // Update is called once per frame
    private void FixedUpdate()
    {
         if(Input.GetKey(KeyCode.D))
     {
         transform.Translate(new Vector3(3 * Time.deltaTime,0,0));
     }
     if(Input.GetKey(KeyCode.A))
     {
         transform.Translate(new Vector3((-3 * Time.deltaTime),0,0));
     }
     if(Input.GetKey(KeyCode.S))
     {
         transform.Translate(new Vector3(0,0,-3 * Time.deltaTime));
     }
     if(Input.GetKey(KeyCode.W))
     {
         transform.Translate(new Vector3(0,0,3 * Time.deltaTime));
     }
    }
}
