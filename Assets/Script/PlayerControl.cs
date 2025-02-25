using UnityEngine;

public class Playercontrol : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    private float movement;
    private float jumpheight = 5f;

    private SpriteRenderer spriteRenderer;
    public Rigidbody2D rb;
    private bool isGround = true;

    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

       
    }

    // Update is called once per frame
    void Update()
    {
       
        movement = Input.GetAxisRaw("Horizontal");

        if (movement > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (movement < 0) { 
            spriteRenderer.flipX = true;
        }
        transform.position += new Vector3(movement, 0, 0) * speed * Time.deltaTime;


        if (Input.GetKey(KeyCode.Space) && isGround == true) {
            Jump();
            isGround = false;
        }
    }


    private void Jump() {

        Vector2 velocity = rb.linearVelocity;
        velocity.y = jumpheight;
        rb.linearVelocity = velocity;
    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") {
            isGround = true;
                }
    }

    
}
