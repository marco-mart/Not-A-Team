using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]private float startingHealth;
    private float currentHealth;
    private Animator anim;
    private bool dead;

    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float damage) 
    {

        currentHealth = Mathf.Clamp(currentHealth - damage, 0, startingHealth);
        
        if (currentHealth > 0)
        {
            // hurt John
            anim.SetTrigger("hurt");
        }

        else
        {
            if (!dead) 
            {
                anim.SetTrigger("die");
                GetComponent<JohnSmith>().enabled = false;
                dead = true;
            }
        }
    }

    // get John's current health
    public float getCurrentHealth() {
        return currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            TakeDamage(1);
        }
    }
}
