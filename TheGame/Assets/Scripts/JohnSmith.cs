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
    bool facingRight = true;
    private GameObject shootingPoint;
    

    private void Awake()
    {
        //grab references
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();

        // get Stapler's shooting point
        shootingPoint = GameObject.Find("ShootingPoint");

        Time.timeScale = 1f; //makes sure the game is running when it starts
    }

    private void Update() {

        horizontalInput = Input.GetAxis("Horizontal");

        // Flip John Smith left or right depending on
        // which direction he is going
        if (horizontalInput > 0 && !facingRight) {
            Flip(shootingPoint);
        }
            
        else if (horizontalInput < 0 && facingRight) {
            Flip(shootingPoint);
        }
            

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
                // FinalCollisionCheck();
            }
        }
        else {
            wallJumpCoolDown += Time.deltaTime;
        }
        
    } //end Update

    // private void FinalCollisionCheck()
    // {
    //     // Get the velocity
    //     Vector2 moveDirection = new Vector2(body.velocity.x * Time.fixedDeltaTime, 0.2f);
         
    //     // Get bounds of Collider
    //     var bottomRight = new Vector2(playerCollider.bounds.max.x, player.collider.bounds.max.y);
    //     var topLeft = new Vector2(playerCollider.bounds.min.x, player.collider.bounds.min.y);
     
    //     // Move collider in direction that we are moving
    //     bottomRight += moveDirection;
    //     topLeft += moveDirection;
                 
    //     // Check if the body's current velocity will result in a collision
    //     if (Physics2D.OverlapArea(topLeft, bottomRight, EnvironmentLayer))
    //     {
    //         // If so, stop the movement
    //         body.velocity = new Vector3(0, rigidBody.velocity.y, 0);
    //     }
    // }


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
                // Flip John Smith to correct direction
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

    private void Flip(GameObject shootingPoint) {

        Vector2 currentScale = transform.localScale;

        // flip shooting point's direction
        shootingPoint.transform.Rotate(0f, 180f, 0f);

        // flip John Smith's direction
        currentScale.x *= -1;

        transform.localScale = currentScale;

        facingRight = !facingRight;
    }
}