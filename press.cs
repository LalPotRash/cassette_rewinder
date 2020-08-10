using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class press : MonoBehaviour{

    void Start(){
        
    }

    void OnMouseDown(){
		Globals.MouseDown = true;
	}

	void OnMouseUp(){
		Globals.MouseDown = false;
	}

	void OnMouseDrag(){
		Globals.MouseDown = false;
	}

    void Update(){
        
    }
}
