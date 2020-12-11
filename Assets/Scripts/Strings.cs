using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

        print("Hola mi nombre es PerkZuwu");
        print("rekkles".Length);
        print("PerkZ".Length + "CAPS".Length); //8
        print("Elefante".Substring(3,4)); //fant

        print(("orange" + "pink")[7]);
        print("black and white".Substring(6,3));

        print("programming"["Hello".Length % "Hi".Length + 7]);

        print("grande".ToUpper());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
