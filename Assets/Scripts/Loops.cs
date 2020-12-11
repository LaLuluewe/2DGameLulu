using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
	public int number = 1;
	public bool state = false;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++){
        	print(i);

        }

        while (number < 10){
        	print(number);
        	number++;
        }

        do{
        	print(number);
        	number++;
        }while(state);

        // Imprimir todos los numeros entre -5 y 5

        for(int i = -5; i <=5; i++){
        	print(i);
        }

        int j = 10;
        while(j <= 50){
        	print(j);
        	j += 2;
        }
        // Imprimir los numeros entre 1 y 100 que son divisibles entre 5 y 3
        
        for(int i = 1; i <= 100; i++){
        	if(i % 5 == 0 && i % 3 == 0){
        		print(i);

        	}
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
        
}
