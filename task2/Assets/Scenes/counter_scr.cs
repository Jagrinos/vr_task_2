using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counter_scr : MonoBehaviour
{
    public Text CounterText;
  
    public colission cubescript;


    void FixedUpdate()
    {
        CounterText.text = "Score: " + cubescript.score;
    }
}
