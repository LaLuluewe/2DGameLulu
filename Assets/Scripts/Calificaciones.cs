using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calificaciones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    	int calificacion = 75;

    	if(calificacion > 89 && calificacion<=100){
    		print("Tienes una A :>");

    	}
    	if(calificacion> 79 && calificacion<=89){
    		print("Tienes una B :p");
    		
    	}
    	if(calificacion> 69 && calificacion<=79){
    		print("Tienes una C :/");
    		
    	}
    	if(calificacion> 64 && calificacion<=69){
    		print("Tienes una D ;-;;-;;-;;-;;-;;-;;-;;-;;-;");
    		
    	}
    	if(calificacion>= 0 && calificacion<=65){
    		print("Tienes una E ehmm.....______________________________________.");
    		
    	}
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
