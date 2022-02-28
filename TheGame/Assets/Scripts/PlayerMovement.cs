using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private float Jump;
    [SerializeField] private LayerMask groundLayer;
    private Rigidbody2D body;
    private Animator anim;
    private BoxCollider2D boxCollider;
    

    private void Awake()
    {
        //grab references
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }
    private void Update() {

        float hInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2( hInput * Speed, body.velocity.y);

        // flip John Smith left or right depending on
        // which direction he is going
        if (hInput > 0) 
            transform.localScale = new Vector2(1, 1);
        else if (hInput < 0)
            transform.localScale = new Vector2(-1, 1);

        //can only jump if grounded, can jump with space or up arrow
        if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow)) && isGrounded()) 
            jump();

        //set animator parameters
        anim.SetBool("run", hInput != 0);
        anim.SetBool("grounded", isGrounded());
        
    } //end Update

    private void jump()
    {
        body.velocity = new Vector2(body.velocity.x, Jump);
        anim.SetTrigger("jump");

    } //end jump

    private void OnCollisionEnter2D(Collision2D collision)
    {
    } //end OnCollisionEnter2D

    private bool isGrounded()
    {
        RaycastHit2D raycast = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return raycast.collider != null;
    }
}