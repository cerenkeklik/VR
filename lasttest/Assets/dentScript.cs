using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dentScript : MonoBehaviour
{
    // Start is called before the first frame update
       int checker=0;
    public GameObject eng;
public void testM(){
if(checker==0){
    Debug.Log("created");
eng=Instantiate(eng, new Vector3(4.265758f,-2,35.38f), Quaternion.identity);
eng.gameObject.SetActive(true);
checker=1;
}else{
     Debug.Log("deleted");
    eng.gameObject.SetActive(false);
    checker=0;
}

}
}
