using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 3.0f;
    public bool vertical;

    Rigidbody2D Rigidbody2D;

    public float changeTime = 3.0f;

    float timer;

    float direction = 1;

    Animator  animator;
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        timer = changeTime;
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0){
            direction = -direction;
            timer = changeTime;


        }
        Vector2 position = Rigidbody2D.position;
        if (vertical){
            position.y = position.y + Time.deltaTime * speed * direction;
            animator.SetFloat("MoveX", 0);
            animator.SetFloat("MoveY", direction);
            
        }else{
            position.x = position.x + Time.deltaTime * speed * direction;
            animator.SetFloat("MoveX", direction);
            animator.SetFloat("MoveY", 0);
            
        }
        

        Rigidbody2D.MovePosition(position);
    }

        void OnCollisionEnter2D(Collision2D other){
            RubyControl player = other.gameObject.GetComponent<RubyControl>();

            if (player != null){
                player.ChangeHealth(-1);

            }

        }
    
}
