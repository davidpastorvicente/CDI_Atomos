using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
	public GameObject tH, tC, tN, tO, tNa, tCl; //targets
    public GameObject h, c, n, o, na, cl; //atomos
	public GameObject h2o1, h2o2, ch41, ch42, co1, co2, nacl1, nacl2, nh31, nh32; //moleculas
	public GameObject hDet, cDet, nDet, oDet, naDet, clDet; //detAtomos
	public GameObject h2oDet, ch4Det, coDet, naclDet, nh3Det; //detMoleculas

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
		if(tH.transform.position.x == 100f) hDet.SetActive(false);
		if(tC.transform.position.x == 200f) cDet.SetActive(false);
		if(tN.transform.position.x == 300f) nDet.SetActive(false);
		if(tO.transform.position.x == 400f) oDet.SetActive(false);
		if(tNa.transform.position.x == 500f) naDet.SetActive(false);
		if(tCl.transform.position.x == 600f) clDet.SetActive(false);
				
		//h2o		
		if (Vector3.Distance(tH.transform.position, tO.transform.position)<10f && aux1) {
			o.SetActive(false);
			h.SetActive(false);
			oDet.SetActive(false);
			hDet.SetActive(false);
			if((tH.transform.position.x - tO.transform.position.x)<0)
				h2o2.SetActive(true);
			else
				h2o1.SetActive(true);
			aux1=false;
		}
		
		
		if(Vector3.Distance(tH.transform.position, tO.transform.position)>=10f && !aux1) {
			o.SetActive(true);
			h.SetActive(true);
			h2o1.SetActive(false);
			h2o2.SetActive(false);
			h2oDet.SetActive(false);
			aux1=true;
		}
		
		//co		
		if (Vector3.Distance(tC.transform.position, tO.transform.position)<10f && aux2) {
			c.SetActive(false);
			o.SetActive(false);
			cDet.SetActive(false);
			oDet.SetActive(false);
			if((tC.transform.position.x - tO.transform.position.x)<0)
				co1.SetActive(true);
			else
				co2.SetActive(true);
			aux2=false;
		}
		
		
		if(Vector3.Distance(tC.transform.position, tO.transform.position)>=10f && !aux2) {
			c.SetActive(true);
			o.SetActive(true);
			co1.SetActive(false);
			co2.SetActive(false);
			coDet.SetActive(false);
			aux2=true;
		}
		
		//nh3	
		if (Vector3.Distance(tN.transform.position, tH.transform.position)<10f && aux3) {
			n.SetActive(false);
			h.SetActive(false);
			nDet.SetActive(false);
			hDet.SetActive(false);
			if((tN.transform.position.x - tH.transform.position.x)<0)
				nh31.SetActive(true);
			else
				nh32.SetActive(true);
			aux3=false;
		}
		
		
		if(Vector3.Distance(tN.transform.position, tH.transform.position)>=10f && !aux3) {
			n.SetActive(true);
			h.SetActive(true);
			nh31.SetActive(false);
			nh32.SetActive(false);
			nh3Det.SetActive(false);
			aux3=true;
		}
		
		//ch4		
		if (Vector3.Distance(tC.transform.position, tH.transform.position)<10f && aux4) {
			c.SetActive(false);
			h.SetActive(false);
			cDet.SetActive(false);
			hDet.SetActive(false);
			if((tC.transform.position.x - tH.transform.position.x)<0)
				ch42.SetActive(true);
			else
				ch41.SetActive(true);
			aux4=false;
		}
		
		
		if(Vector3.Distance(tC.transform.position, tH.transform.position)>=10f && !aux4) {
			c.SetActive(true);
			h.SetActive(true);
			ch41.SetActive(false);
			ch42.SetActive(false);
			ch4Det.SetActive(false);
			aux4=true;
		}
		
		//nacl		
		if (Vector3.Distance(tNa.transform.position, tCl.transform.position)<10f && aux5) {
			na.SetActive(false);
			cl.SetActive(false);
			naDet.SetActive(false);
			clDet.SetActive(false);
			if((tNa.transform.position.x - tCl.transform.position.x)<0)
				nacl1.SetActive(true);
			else
				nacl2.SetActive(true);
			aux5=false;
		}
		
		
		if(Vector3.Distance(tNa.transform.position, tCl.transform.position)>=10f && !aux5) {
			na.SetActive(true);
			cl.SetActive(true);
			nacl1.SetActive(false);
			nacl2.SetActive(false);
			naclDet.SetActive(false);
			aux5=true;
		}
		
		if(Input.GetKeyDown(KeyCode.I)) {
			if(aux1) {
				if(tH.transform.position.x != 100f && aux3 && aux4) hDet.SetActive(true);
				if(tO.transform.position.x != 400f && aux2) oDet.SetActive(true);
			}
			else h2oDet.SetActive(true);
			
			if(aux2) {
				if(tC.transform.position.x != 200f && aux4) cDet.SetActive(true);
				if(tO.transform.position.x != 400f && aux1) oDet.SetActive(true);
			}
			else coDet.SetActive(true);
			
			if(aux3) {
				if(tN.transform.position.x != 300f) nDet.SetActive(true);
				if(tH.transform.position.x != 100f && aux1 && aux4) hDet.SetActive(true);
			}
			else nh3Det.SetActive(true);
			
			if(aux4) {
				if(tH.transform.position.x != 100f && aux1 && aux3) hDet.SetActive(true);
				if(tC.transform.position.x != 200f && aux2) cDet.SetActive(true);
			}
			else ch4Det.SetActive(true);
			
			if(aux5) {
				if(tNa.transform.position.x != 500f) naDet.SetActive(true);
				if(tCl.transform.position.x != 600f) clDet.SetActive(true);
			}
			else naclDet.SetActive(true);
		}		
    }
}
