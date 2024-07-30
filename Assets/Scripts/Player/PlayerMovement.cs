using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    [SerializeField] private float flapStrength;
    public Rigidbody2D bird;
    public Animator anim;
    public float Speed;
    public LogicScript logic;
    public bool birdIsAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    private void Update()
    {
        bird.velocity = new Vector2(Input.GetAxis("Horizontal") * flapStrength, bird.velocity.y);
        transform.Translate( Time.deltaTime * Speed ,0,0);

        if(Input.GetKey(KeyCode.Space) && birdIsAlive)
            bird.velocity = new Vector2(bird.velocity.x , flapStrength);

        anim.SetBool("fly", Input.GetKey(KeyCode.Space));
    }

    private void OnCollisionEnter2D(Collision2D collision){
        
        logic.gameOver();
        birdIsAlive = false;

    }
}
