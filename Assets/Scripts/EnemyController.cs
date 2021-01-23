using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 3.0f;
    public bool vertical;

    Rigidbody2D rigidbody2D;

    public float changeTime = 3.0f;

    float timer;

    float direction = 1;

    bool repaired = false;
    
    public GameObject smokeParticleEffect;

    AudioSource audioSource;

    public ParticleSystem smokeEffect;

    Animator  animator;

    public AudioClip hitSound;

    public AudioClip fixedSound;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        timer = changeTime;
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        if(repaired)
            return;


        timer -= Time.deltaTime;
        if(timer < 0){
            direction = -direction;
            timer = changeTime;


        }
        Vector2 position = rigidbody2D.position;
        if (vertical){
            position.y = position.y + Time.deltaTime * speed * direction;
            animator.SetFloat("MoveX", 0);
            animator.SetFloat("MoveY", direction);
            
        }else{
            position.x = position.x + Time.deltaTime * speed * direction;
            animator.SetFloat("MoveX", direction);
            animator.SetFloat("MoveY", 0);
            
        }
        

        rigidbody2D.MovePosition(position);
    }

        void OnCollisionEnter2D(Collision2D other){
            RubyControl player = other.gameObject.GetComponent<RubyControl>();

            if (player != null){
                player.ChangeHealth(-1);

            }

        }
    
    public void Fix(){
        animator.SetTrigger("Fixed");

        repaired = true;

        smokeParticleEffect.SetActive(false);
        Debug.Log("Entro al fix");


        rigidbody2D.simulated = false;

        audioSource.Stop();
        audioSource.PlayOneShot(hitSound);
        audioSource.PlayOneShot(fixedSound);
    }
}


