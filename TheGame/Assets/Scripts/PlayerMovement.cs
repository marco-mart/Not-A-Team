using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private float Jump;
    private Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    private void Update() {

        float hInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2( hInput * Speed, body.velocity.y);

        // flip John Smith left or right depending on
        // which direction he is going
        if (hInput > 0) {
            transform.localScale = new Vector2(1, 1);
        }
        else if (hInput < 0) {
            transform.localScale = new Vector2(-1, 1);
        }

        if (Input.GetKey(KeyCode.Space))
            body.velocity = new Vector2(body.velocity.x, Jump);
        
    }
}