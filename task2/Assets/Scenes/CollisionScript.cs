using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colission : MonoBehaviour
{

    public int score = 1000;

    public void OnCollisionEnter()
    {
        

       // Debug.Log("FFF");

        score--;
    }
    
 
}
