using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D body;
    [SerializeField] private float damage;

    // Start is called before the first frame update
    void Start()
    {
        body.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo) {

        // get staple off screen
        Destroy(gameObject);

        if (hitInfo.CompareTag("Enemy")) {
            Debug.Log(hitInfo.name);

            if (hitInfo.name.StartsWith("Brussels")) {
                BrusselsSprout enemy = hitInfo.GetComponent<BrusselsSprout>();

                enemy.TakeDamage(damage);
            }
            else if (hitInfo.name.StartsWith("Book")) {
                // book stuff
            }
        }

        
    }

}
