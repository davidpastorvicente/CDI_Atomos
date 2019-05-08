using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NivelM : MonoBehaviour
{

float vel= 25f;
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(-vel * Time.deltaTime, vel * Time.deltaTime, vel * Time.deltaTime);
    }
}
