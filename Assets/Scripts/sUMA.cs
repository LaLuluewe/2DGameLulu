using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sUMA : MonoBehaviour
{

	int[] suma = new int[] {5, 10, 2};
	int[] suma2 = new int[] {10, 20, 30, 40, 50};
    // Start is called before the first frame update
    int Sumar(int[] arr){
        	int result = 0;
        	for(int i = 0; i < arr.Length; i++){
        		result += arr[i];
        	}

        	return result;
        }

        void Restar(int[] arr){
        	int result = 5;
        	for(int o = arr.Length -1; o > -1; o--){
        		print(arr[o]);

        	}
        }

        int Maximo(int[] arr){
        	int max = 0;
        	for (int i = 0; i < arr.Length; i++){
        		if(arr[i] > max) max = arr[i];

        	}
        	return max;
        
        	
    	}

    void Start()
    {
    	print(Sumar(suma));
    	print(Sumar(suma2));
       	Restar(suma2);
       	print(Maximo(suma2));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
