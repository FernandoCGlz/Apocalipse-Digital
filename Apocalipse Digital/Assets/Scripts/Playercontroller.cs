using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpHeight = 10f;

    float velX, velY;
    Rigidbody2D rb;
    public Transform groundcheck;
    public bool isGrounded;
    public float groundCheckRadius;
    public LayerMask whatsIsGround;
    Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        transform.localScale = new Vector3(1, 1, 1); 
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundcheck.position, groundCheckRadius, whatsIsGround);

        if (isGrounded){
            anim.SetBool("Jump", false);
         }
         else {
            anim.SetBool("Jump", true);
         }

        Movement();
        FlipCharacter();
        Jump();
    }

    public void Movement()
    {
        velX = Input.GetAxisRaw("Horizontal");
        velY = rb.linearVelocity.y;

        rb.linearVelocity = new Vector2(velX * speed, velY);

        if(rb.linearVelocity.x !=0){
            anim.SetBool("Walk",true);
        }
        else{
            anim.SetBool("Walk",false);
        }
    }

    public void FlipCharacter()
    {
        if (velX > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (velX < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    public void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpHeight);
        }
    }

   
}
