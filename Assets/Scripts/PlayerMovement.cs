using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    [SerializeField] private float speed;
    private Rigidbody2D bird;

    private void Awake(){
        bird = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        bird.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, bird.velocity.y);
        transform.Translate( Time.deltaTime,0,0);

        if(Input.GetKey(KeyCode.Space))
            bird.velocity = new Vector2(bird.velocity.x , speed);
            
        //if()
    }
}
