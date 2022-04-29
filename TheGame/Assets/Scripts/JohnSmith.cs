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
    private float shootingCooldown = 0;
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
    } // end Awake

    private void Update() {

        horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2( horizontalInput * Speed, body.velocity.y);

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

        //can only jump if grounded, can jump with space or up arrow
        if ((Input.GetKey(KeyCode.UpArrow))) {
            jump();
        }

        if (Input.GetKey(KeyCode.Space) && shootingCooldown > 0.5f) {
            anim.SetTrigger("shoot");
            shootingCooldown = 0;
        } //end if
        else {
            anim.SetTrigger("dontShoot");
            shootingCooldown += Time.deltaTime;
        } //end else

        //print("Shoot Cool: " + shootingCooldown);
        
    } // end Update


    private void jump()
    {
        if (isGrounded()) {
            body.velocity = new Vector2(body.velocity.x, jumpPower);
            anim.SetTrigger("jump");
        }

    } // end jump

    private bool isGrounded()
    {
        RaycastHit2D raycast = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return raycast.collider != null;
    } // end isGrounded

    private bool onWall()
    {
        RaycastHit2D raycast = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, new Vector2(transform.localScale.x, 0), 0.1f, wallLayer);
        return raycast.collider != null;
    } // end onWall

    private void Flip(GameObject shootingPoint) {

        Vector2 currentScale = transform.localScale;

        // flip shooting point's direction
        shootingPoint.transform.Rotate(0f, 180f, 0f);

        // flip John Smith's direction
        currentScale.x *= -1;

        transform.localScale = currentScale;

        facingRight = !facingRight;

    } // end Flip
    
} // end John Smith