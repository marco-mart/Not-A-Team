using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

public class BrusselsSprout : MonoBehaviour
{
    [SerializeField] private float Speed;
    private Rigidbody2D body;
    private Animator anim;
    private BoxCollider2D boxCollider;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask wallLayer;
    private int state;
    private float turnCooldown;
    [SerializeField] private int damage; 
    private float damageCooldown;


    // Awake is called before the first frame update
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
        damageCooldown = 0;

        state = 1; //1 = right, -1 = left, brussel sprout always starts to the right
    }

    // Update is called once per frame
    private void Update()
    {

        anim.SetBool("right", state == 1);
        anim.SetBool("left", state == -1);

        if (GetComponent<Health>().getCurrentHealth() > 0)
            body.velocity = new Vector2(Speed * state, body.velocity.y);  
            

        if (onWall() && turnCooldown > 0.3f)
        {
            state = -state;
            turnCooldown = 0;
        }

        turnCooldown += Time.deltaTime;
        damageCooldown += Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.tag == "Player" && damageCooldown > 3f)
        {
            damageCooldown = 0;
            collision.GetComponent<Health>().TakeDamage(damage);
        }

        damageCooldown += Time.deltaTime;
    }

    private bool onWall()
    {
        RaycastHit2D raycast = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, new Vector2(transform.localScale.x, 0), 0.1f, wallLayer);
        return raycast.collider != null;
    }

    public void TakeDamage(float d) {
        GetComponent<Health>().TakeDamage(d);
    }

    
}
