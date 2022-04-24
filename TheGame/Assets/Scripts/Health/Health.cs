using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]private float startingHealth;
    private float currentHealth;
    private Animator anim;
    private bool dead = false;
    private float wait;

    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        wait = 0;
    }

    private void Update() {
        if (dead) {
            // start timer
            wait += Time.deltaTime;
        }
    }

    public void TakeDamage(float damage) 
    {

        currentHealth = Mathf.Clamp(currentHealth - damage, 0, startingHealth);
        
        print(gameObject.name + "\nCurrent health = " + currentHealth);


        if (currentHealth > 0)
        {
            // hurt animation
            anim.SetTrigger("hurt");
        }

        else
        {
            if (!dead) 
            {
                // die animation
                anim.SetTrigger("die");
                if (gameObject.tag == "Player") {
                    GetComponent<JohnSmith>().enabled = false;
                }
                else if (gameObject.tag == "Enemy") {

                    // wait like 3 secs
                    Destroy(gameObject);
                }

                dead = true;
            }
        }
    }

    // get object's current health
    public float getCurrentHealth() {
        return currentHealth;
    }

    public void addHealth(float value) {
        currentHealth = Mathf.Clamp(currentHealth + value, 0, startingHealth);
    }

}
