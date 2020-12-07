using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audiolvl11 : MonoBehaviour
{
    private static Audiolvl11 aInstance;
    
    void Awake(){
        
        
        DontDestroyOnLoad (this);

        if (aInstance == null) {
            aInstance = this;
         } 
         else {
             Destroy(gameObject);
        }
        
    }


}
