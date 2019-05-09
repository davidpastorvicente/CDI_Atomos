using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject h, c, n, o, na, cl;
	public GameObject h2o, ch4, co, nacl, nh3;
	//public GameObject mol;
	public bool aux;
	
	void Start() {
		aux=false;
	}

    void Update()
    {
		
		if(Math.Abs((h.transform.position.x - o.transform.position.x))<10 && !aux) {
			o.SetActive(false);
			h.SetActive(false);
			h2o.SetActive(true);
			aux=true;
		}
		
		if(Math.Abs((h.transform.position.x - o.transform.position.x))>=10 && aux) {
			o.SetActive(true);
			h.SetActive(true);
			h2o.SetActive(false);
			aux=false;
		}
		
    }
}
