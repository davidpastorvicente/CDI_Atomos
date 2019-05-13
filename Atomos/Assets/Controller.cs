using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
	public GameObject tH, tC, tN, tO, tNa, tCl; //targets
    public GameObject h, c, n, o, na, cl; //atomos
	public GameObject h2o1, h2o2, ch41, ch42, co1, co2, nacl1, nacl2, nh31, nh32; //moleculas

	public bool aux1, aux2, aux3, aux4, aux5;
	
	void Start() {
		aux1=true; //c o
		aux2=true; // n h
		aux3=true; //na cl
		aux4=true;
		aux5=true;
		tH.transform.position= new Vector3(100f, 0f, 0f);
		tC.transform.position= new Vector3(200f, 0f, 0f);
		tN.transform.position= new Vector3(300f, 0f, 0f);
		tO.transform.position= new Vector3(400f, 0f, 0f);
		tNa.transform.position= new Vector3(500f, 0f, 0f);
		tCl.transform.position= new Vector3(600f, 0f, 0f);
	}

    void Update()
    {
		//h2o		
		if (Math.Abs((tH.transform.position.x - tO.transform.position.x))<10f && aux1) {
			o.SetActive(false);
			h.SetActive(false);
			if((tH.transform.position.x - tO.transform.position.x)<0)
				h2o2.SetActive(true);
			else
				h2o1.SetActive(true);
			aux1=false;
		}
		
		
		if(Math.Abs((tH.transform.position.x - tO.transform.position.x))>=10f && !aux1) {
			o.SetActive(true);
			h.SetActive(true);
			h2o1.SetActive(false);
			h2o2.SetActive(false);
			aux1=true;
		}
		
		//co		
		if (Math.Abs((tC.transform.position.x - tO.transform.position.x))<10f && aux2) {
			c.SetActive(false);
			o.SetActive(false);
			if((tC.transform.position.x - tO.transform.position.x)<0)
				co1.SetActive(true);
			else
				co2.SetActive(true);
			aux2=false;
		}
		
		
		if(Math.Abs((tC.transform.position.x - tO.transform.position.x))>=10f && !aux2) {
			c.SetActive(true);
			o.SetActive(true);
			co1.SetActive(false);
			co2.SetActive(false);
			aux2=true;
		}
		
		//nh3	
		if (Math.Abs((tN.transform.position.x - tH.transform.position.x))<10f && aux3) {
			n.SetActive(false);
			h.SetActive(false);
			if((tN.transform.position.x - tH.transform.position.x)<0)
				nh31.SetActive(true);
			else
				nh32.SetActive(true);
			aux3=false;
		}
		
		
		if(Math.Abs((tN.transform.position.x - tH.transform.position.x))>=10f && !aux3) {
			n.SetActive(true);
			h.SetActive(true);
			nh31.SetActive(false);
			nh32.SetActive(false);
			aux3=true;
		}
		
		//ch4		
		if (Math.Abs((tC.transform.position.x - tH.transform.position.x))<10f && aux4) {
			c.SetActive(false);
			h.SetActive(false);
			if((tC.transform.position.x - tH.transform.position.x)<0)
				ch41.SetActive(true);
			else
				ch42.SetActive(true);
			aux4=false;
		}
		
		
		if(Math.Abs((tC.transform.position.x - tH.transform.position.x))>=10f && !aux4) {
			c.SetActive(true);
			h.SetActive(true);
			ch41.SetActive(false);
			ch42.SetActive(false);
			aux4=true;
		}
		
		//nacl		
		if (Math.Abs((tNa.transform.position.x - tCl.transform.position.x))<10f && aux5) {
			na.SetActive(false);
			cl.SetActive(false);
			if((tNa.transform.position.x - tCl.transform.position.x)<0)
				nacl1.SetActive(true);
			else
				nacl2.SetActive(true);
			aux5=false;
		}
		
		
		if(Math.Abs((tNa.transform.position.x - tCl.transform.position.x))>=10f && !aux5) {
			na.SetActive(true);
			cl.SetActive(true);
			nacl1.SetActive(false);
			nacl2.SetActive(false);
			aux5=true;
		}
		
    }
}
