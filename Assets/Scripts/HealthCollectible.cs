using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
	void OnTriggerStay2D(Collider2D other){
		//Debug.Log("El objeto hizo collision con el trigger: " + other);
		RubyControl controller = other.GetComponent<RubyControl>();
		if(controller != null){
			if(controller.health < controller.maxHealth){
				controller.ChangeHealth(1);
				Destroy(gameObject);
			}



		}
	}
}
