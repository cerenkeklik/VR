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
        if(camera_movement.transform.eulerAngles.x > 10)
        {
            camera_Set = (camera_movement.transform.position - transform.position).normalized;
            camera_Set.Set(camera_Set.x, 0, camera_Set.z);
            transform.position += camera_Set * Time.deltaTime;
        }
    }
}
