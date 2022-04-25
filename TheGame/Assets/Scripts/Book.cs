using UnityEngine;

public class Book : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private Animator anim;
    private BoxCollider2D boxCollider;
    [SerializeField] private float damage; 
    private float damageCooldown;
    public Transform targetPlayer;
    private bool playerDetected = false;
    [SerializeField] public float distance;
    private float far;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
        damageCooldown = 0;
    }

    // Update is called once per frame
    void Update() {

        far = Vector2.Distance(transform.position, targetPlayer.position);

        print(far);

        if (far < distance)
            playerDetected = true;
        else    
            playerDetected = false;

        print(playerDetected);

        if (playerDetected) {
            //body.velocity = new Vector2(speed,0);

            anim.SetTrigger("chase");
            transform.position = Vector2.MoveTowards(transform.position, targetPlayer.position, speed * Time.deltaTime);

            if (transform.position.x > targetPlayer.position.x)
                transform.localScale = new Vector2(-0.15f, 0.15f);
            else 
                transform.localScale = new Vector2(0.15f, 0.15f);
        } //end if
        else {
            anim.SetTrigger("flap");
            body.velocity = new Vector2(speed,0);
            transform.localScale = new Vector2(0.15f, 0.15f);
        } //end else



    } //end Update

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        //Debug.Log("Hit detected.");
        if (collision.tag == "Player" && damageCooldown > 0.05f)
        {
            damageCooldown = 0;
            collision.GetComponent<Health>().TakeDamage(damage);
        }

        damageCooldown += Time.deltaTime;
    }

    public void TakeDamage(float d) {
        GetComponent<Health>().TakeDamage(d);
    }
} //end class
