using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    	string name = "perkz";
    	string weapon = "Sword";
    	int health = 10;
    	float speed = 5.5f;
    	int enemyDamage = 2;

    	print("Welcome " + "Warrior " + name);
        print("The enemy found you because your'e so slow because your velocity is only: " + speed);

        health -= enemyDamage;

        print("The enemy hit you " + enemyDamage.ToString() + "so you have got" + health.ToString() + "health left.");
        print("After all worth you killed your enemy with your " + weapon);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
