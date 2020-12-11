using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
	string name1 = "Bob";
	string name2 = "Sam";
	string name3 = "Lili";
	string name4 = "Beto";
	string name5 = "Alex";

	string[] playerNames = new string[] {"Bob", "Sam", "Lili", "Beto", "Alex"};

	string[] playerName2 = new string[5];

	int[] randomNumbers = new int[3] ;

    // Hola uwuwuuw
    // Start is called before the first frame update
    void Start()
    {
        print(playerNames[0]);
        print(playerNames[3]);

        playerName2[0] = "Luka";
        print(playerName2[1]);

        print(playerNames.Length);
        print(playerName2.Length);

        for(int i = 0; i < randomNumbers.Length; i ++){
        	randomNumbers[i] = Random.Range(0, 100);
        	print(randomNumbers[i]);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
