using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyControl : MonoBehaviour
{
    // ---------MOVIEMINETO-----
    // Start is called before the first frame update

    // ------HEALTH---
    public float speed = 0f;
    public int maxHealth = 5;
    public int health {get {return currentHealth;}}
    private int currentHealth;

    public float timeInvisible = 2.0f;
    bool isInvisible = true;
    float InvisibleTimer;

    Rigidbody2D rigidbody2d;
    Animator animator;

    Vector2 lookDirection = new Vector2(1, 0);

    // proyectil
    public GameObject proyectilPrefab;

    //++++++AUDIO=======
    public AudioClip shootingSound;
    public AudioClip hitSound;

    AudioSource audioSource;

    public Transform respawnPosition;

    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 10;

        //AUDIO
        audioSource =GetComponent<AudioSource>();

        //MOVIMIENTO 
        rigidbody2d = GetComponent<Rigidbody2D>();
        //ANIMACION
        animator = GetComponent<Animator>();

        //HEATLH
        currentHealth = maxHealth;



    }

    // Update is called once per frame
    void Update()
    {
        //HEALTH
        if(isInvisible){
            InvisibleTimer -= Time.deltaTime;
            if(InvisibleTimer < 0){
                isInvisible = false;

            }
        }

        //MOVIMIENTO
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Vector2 move = new Vector2(horizontal, vertical);

        if(!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f)){
            lookDirection.Set(move.x, move.y);
            lookDirection.Normalize();
        }       

        animator.SetFloat("Look X", lookDirection.x);
        animator.SetFloat("Look Y", lookDirection.y);
        animator.SetFloat("Speed", move.magnitude);


       // Debug.Log(horizontal);

       //MOVIMETO
        Vector2 position = rigidbody2d.position;
        position = position + move * speed * Time.deltaTime;

        rigidbody2d.MovePosition(position);
        position.x = position.x +  speed * horizontal;
        position.y = position.y + speed * vertical;
        
        rigidbody2d.MovePosition(position);


  

        if(Input.GetKeyDown(KeyCode.Space)){
            Launch();


        }
        if(Input.GetKeyDown(KeyCode.X)){
            RaycastHit2D hit = Physics2D.Raycast(rigidbody2d.position + Vector2.up * 0.2f, lookDirection, 1.5f, LayerMask.GetMask("NPC"));
            if(hit.collider != null){
                NonPlayerCharacter character = hit.collider.GetComponent<NonPlayerCharacter>();
                if(character != null){
                    character.DisplayDialog();
                }
            

            }
        }


    }


        //HEATLH
    public void ChangeHealth(int amount){
        if(amount < 0){
            if(isInvisible){
                return;
            }
            isInvisible = true;
            InvisibleTimer = timeInvisible;
            audioSource.PlayOneShot(hitSound);


        }
        animator.SetTrigger("Hit");
        audioSource.PlayOneShot(hitSound);

        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        if(currentHealth == 0){
            Respawn();

        }
        UIHealthBar.instance.SetValue(currentHealth / (float)maxHealth);

    }

    void Respawn(){
        ChangeHealth(maxHealth);
        transform.position = respawnPosition.position;
    }

    void Launch(){
        GameObject proyectilObject = Instantiate(proyectilPrefab, rigidbody2d.position + Vector2.up *0.5f, Quaternion.identity);

        Proyectil proyectil = proyectilObject.GetComponent<Proyectil>();
        proyectil.Launch(lookDirection, 300);

        animator.SetTrigger("Launch");
        audioSource.PlayOneShot(shootingSound);
    }


}