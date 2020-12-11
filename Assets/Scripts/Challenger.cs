using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    	string nombre = "Lulu";
    	string apellido = "Vazquez";
    	int nacimiento = 2007;


    	print("Mi nombre es: " + nombre + "y me gusta hacer cosas random :>");
    	print("Mis iniciales son: " + nombre[0] + apellido[0] );
    	print("Longitud de mi nombre: " + "Lulu".Length);
    	print("Naci el " + nacimiento + " asi que tengo " + (2020 - 2007) + " años");
    	print("Ya vivi " + (2007 * 365) + " dias");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
