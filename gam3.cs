using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class gam3 : MonoBehaviour{

	public GameObject cassette;
	public GameObject strt;
	public GameObject menu;
	public Vector3 resp;
	bool MouseDown = false;


    void Start(){
        //other.attachedRigidbody.useGravity = true;
    }

    void OnMouseDown(){
		MouseDown = true;
	}

	void OnMouseUp(){
		MouseDown = false;
	}

	void OnMouseDrag(){
		MouseDown = false;
	}

    void OnTriggerEnter(Collider collider){
    	if (collider.gameObject.tag == "Start"){
    		Globals.start = true;
    		cassette.GetComponent<Rigidbody>().isKinematic = true;
    	}
		if (collider.gameObject.tag == "Finish"){
			if (Globals.start == true){
				Globals.play = false;
    			Globals.start = false;	
		    	SceneManager.LoadScene("gam3");				
			}
		}
	}

	protected void LateUpdate(){
	    transform.localEulerAngles = new Vector3(90, transform.localEulerAngles.y, transform.localEulerAngles.z);
	}

    void Update(){
	    if (Globals.MouseDown){
	    	if (Globals.start == true){
		    	menu.SetActive(false);
		    	strt.SetActive(false);
		    	cassette.GetComponent<Rigidbody>().useGravity = false;
		    	cassette.GetComponent<Rigidbody>().isKinematic = false;
			    Globals.x += 5;

			    //transform.position = Vector3.Lerp(transform.position, new Vector3(0, next.transform.position.y, 0), 0.5f * Time.deltaTime);

			    //cassette.transform.position += Vector3.up * 30f * Time.deltaTime;

			    cassette.transform.Translate(0f, 0f, -0.2f); //old, but gold
			    
			    Globals.play = true;	
		    }        
		}
		else{
		  	if (Globals.play == true){
		   		Globals.x--;
		   		cassette.transform.Translate(0f, 0f, 0.01f);
		   	}
		}
	    if (Globals.x < 60){
	    	Globals.x = 60;
	    }

	    if (Globals.start == true){
	    	this.transform.RotateAround(new Vector3(-1.038f, 0f, 0.17f), new Vector3(0f, -5f, 0f), Globals.x * Time.deltaTime);//u spin m3 r1ght r0und, b4by rght rnd
	    }
    }
}
