using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NivelK : MonoBehaviour
{

float vel= 100f;
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
