using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]private float startingHealth;
    private float currentHealth;
    private Animator anim;
    private bool dead = false;
    private float wait = 0;

    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        wait = 0;
    }

    private void Update() {
        if (dead && wait > 1f) {
            // start timer
           Destroy(gameObject);
        }
        else if (dead && wait < 2f)
            wait += Time.deltaTime;
    }

    public void TakeDamage(float damage) 
    {

        currentHealth = Mathf.Clamp(currentHealth - damage, 0, startingHealth);
        
        //print(gameObject.name + "\nCurrent health = " + currentHealth);


        if (currentHealth > 0)
        {
            // hurt animation
            anim.SetTrigger("hurt");
            
        }

        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            // die animation
            anim.SetTrigger("die");

            if (gameObject.tag == "Player") {
                GetComponent<JohnSmith>().enabled = false;
            }
            else if (gameObject.tag == "Enemy") {

                // wait like 3 secs
                dead = true;
                
            }

            
            
        } //end else
    } //end takeDamage

    // get object's current health
    public float getCurrentHealth() {
        return currentHealth;
    }

    public void addHealth(float value) {
        currentHealth = Mathf.Clamp(currentHealth + value, 0, startingHealth);
    }

    public void setCurrentHealth(float c)
    {
        currentHealth = c;
    }

}
