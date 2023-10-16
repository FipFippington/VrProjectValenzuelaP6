using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotat : MonoBehaviour
{
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.isPlaying)
        {
            transform.Rotate(0.0f, 2.0f, 0.0f);
        }
    } 
}
