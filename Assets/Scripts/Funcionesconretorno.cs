using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcionesconretorno : MonoBehaviour
{
    // Start is called before the first frame update

    int cunt = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void suma()
    {
        int numb = 3;
        int numc = 0;

        numc = numb + numb;
        print("La suma de A y B es " + numc); 
        
    }

    int suma2(){
        int numb = 3;
        int numc = 0;

       // numc = numb + numa;
        return numc;


    }
    bool isTrue(){
        bool isAlive = true;

        return isAlive;
    }
}
