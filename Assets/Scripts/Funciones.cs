using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones : MonoBehaviour
{	
	public string name;
	int health = 10;
	public int damageAmount;

	void welcomePlayer (string playerName){
		print("Welcome " + playerName);
		print("Good Luck");
	}


	void takeDamage(int damage){
		health -= damage;
		print("Ouch! You took damage! Your helth is: " + health );

	}
    // Start is called before the first frame update 

	bool isAlive(){
		if(health <= 0){
			print("Game over :C");
			return false;
		}else{
			return true;
		}
	}

    void Start()
    {
        welcomePlayer(name);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && isAlive()){
        	takeDamage(damageAmount);

        }
    }
}
