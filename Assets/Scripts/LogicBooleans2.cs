using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicBooleans2 : MonoBehaviour
{
    // Start is called before the first frame update
	void Start()    
    {
    	bool complexStatement = 5 < 10 && 5 != 5 ;
    	print(complexStatement);

    	bool complexStatement2 = 5 < 10 || 5 !=5;
    	print(complexStatement2);


        //Problema 1
        print((5 % 2 == 1 && 10 > 10) || (5*5 ==10 || "hey" == "hey"));

        print(("hello".Length >= 5 && 3.5f > 3.45f) && ("dragon".Length < 6 || "a" == "A"));

        string name = "bob";
        string color = "blue";
        print((name.Length > color.Length || name[0] == color[0]) || (name[2] == color[0] && 1 != 1));
        // 3, 4                            V  V                    v         V, F           F

        // F


    }

    // Update is called once per frame
    void Update()
    {

    }
   
}
