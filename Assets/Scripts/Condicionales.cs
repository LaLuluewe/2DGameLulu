using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionales : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    	string playerName = "PERKZ";
    	string playerName2 = "Perokiv";

    	if (playerName.Length <= 5){
    		print("Player name to short");
    	}

    	if (playerName2.Length <= 5){
    		print("Player name to short");
    	}else{
    		print("Player name ok :>");
    	}

    		
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
