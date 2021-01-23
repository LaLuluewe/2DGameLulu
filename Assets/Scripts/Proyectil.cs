using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{   

    Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        
    }

    void update(){
        if(transform.position.magnitude > 100.0f){
            Destroy(gameObject);
            
        }
    }

    // Update is called once per frame
    public void Launch(Vector2 direction, float force){
        rigidbody2D.AddForce(direction * force);

    }

    void OnCollisionEnter2D(Collision2D other) {
        EnemyController e = other.collider.GetComponent<EnemyController>();

        if(e != null){
            e.Fix();

        }

        Debug.Log("El proyectil hizo colision con: " + other.gameObject);
        Destroy(gameObject);
        
    }

}
