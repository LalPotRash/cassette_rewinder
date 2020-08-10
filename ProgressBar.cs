using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour{

	private Slider slider;
	private float targetProgress = 0;

	private void Awake(){
		slider = gameObject.GetComponent<Slider>();
	}
    
    void Start(){
        
    }

    
    void Update(){
    	if (Globals.play == true){
    		slider.value += 0.1f * Time.deltaTime;
    	}   
    }
}
