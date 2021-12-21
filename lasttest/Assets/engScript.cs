using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engScript : MonoBehaviour
{
    int checker=0;
    public GameObject eng;
public void testM(){
if(checker==0){
eng=Instantiate(eng, new Vector3(3.41f,-2,15), Quaternion.identity);
eng.gameObject.SetActive(true);
checker=1;
}else{
    eng.gameObject.SetActive(false);
    checker=0;
}

}
    
}
