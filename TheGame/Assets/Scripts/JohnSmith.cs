using UnityEngine;

public class JohnSmith : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private float jumpPower;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask wallLayer;
    private Rigidbody2D body;
    private Animator anim;
    private BoxCollider2D boxCollider;
    private float wallJumpCoolDown;
    private float horizontalInput;
    

    private void Awake()
    {
        //grab references
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update() {

        horizontalInput = Input.GetAxis("Horizontal");

        // flip John Smith left or right depending on
        // which direction he is going
        if (horizontalInput > 0) 
            transform.localScale = new Vector2(3, 3);
        else if (horizontalInput < 0)
            transform.localScale = new Vector2(-3, 3);

        //set animator parameters
        anim.SetBool("run", horizontalInput != 0);
        anim.SetBool("grounded", isGrounded());

        // wall jump logic
        if (wallJumpCoolDown > 0.2f) {
            
            body.velocity = new Vector2( horizontalInput * Speed, body.velocity.y);

            if (onWall() && !isGrounded()) {
                body.gravityScale = 0;
                body.velocity = Vector2.zero;
            }
            else {
                body.gravityScale = 1;
            }

            //can only jump if grounded, can jump with space or up arrow
            if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow))) {
                jump();
            }
        }
        else {
            wallJumpCoolDown += Time.deltaTime;
        }
        
    } //end Update

    private void jump()
    {
        if (isGrounded()) {
            body.velocity = new Vector2(body.velocity.x, jumpPower);
            anim.SetTrigger("jump");
        }
        else if (onWall() && !isGrounded()) {

            if (horizontalInput == 0) {
                // push John Smith to other direction
                body.velocity = new Vector2(-Mathf.Sign(transform.localScale.x) * 10, 0);
                // flip John Smith to correct direction
                if (transform.localScale.x > 0) {
                    transform.localScale = new Vector2(-Mathf.Sign(transform.localScale.x) * transform.localScale.x, transform.localScale.y);
                }
                else {
                    transform.localScale = new Vector2(Mathf.Sign(transform.localScale.x) * transform.localScale.x, transform.localScale.y);
                }
            }
            else {
                // wall jump in opposite direction as wall 
                // ex. left and up or right and up
                body.velocity = new Vector2(-Mathf.Sign(transform.localScale.x) * 10, 10);
            }

            wallJumpCoolDown = 0;
        }

    } //end jump

    private void OnCollisionEnter2D(Collision2D collision)
    {
    } //end OnCollisionEnter2D

    private bool isGrounded()
    {
        RaycastHit2D raycast = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return raycast.collider != null;
    }

    private bool onWall()
    {
        RaycastHit2D raycast = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, new Vector2(transform.localScale.x, 0), 0.1f, wallLayer);
        return raycast.collider != null;
    }
}