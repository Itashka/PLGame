using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 moveVector;
    public float speed = 2f;
    public Animator anim;
    public SpriteRenderer sr;
    public float JumpForse = 7f;
    public bool onGround;
    public Transform GroundCheck;
    public float checkRadius = 0.4f;
    public LayerMask Ground;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        Flip();
        Jump();
        CheckingGround();
    }
    void Run()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        anim.SetFloat("MoveX", Mathf.Abs(moveVector.x));
        rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);
    }
    void Flip()
    {
        if (moveVector.x > 0)
            sr.flipX = false;
        if (moveVector.x < 0)
            sr.flipX = true;
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.W) && onGround)
            //rb.velocity = new Vector2(rb.velocity.x, JumpForse);
            rb.AddForce(Vector2.up * JumpForse);
    }
    void CheckingGround()
    {
        onGround = Physics2D.OverlapCircle(GroundCheck.position, checkRadius, Ground);
        anim.SetBool("onGround", onGround);
    }
}
