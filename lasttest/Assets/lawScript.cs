using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lawScript : MonoBehaviour
{
    // Start is called before the first frame update
       int checker=0;
    public GameObject eng;
public void testM(){
if(checker==0){
eng=Instantiate(eng, new Vector3(-0.4392f,5,7.7393f), Quaternion.identity);
eng.gameObject.SetActive(true);
checker=1;
}else{
    eng.gameObject.SetActive(false);
    checker=0;
}

}
}
