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
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * Speed, body.velocity.y);

        if (Input.GetKey(KeyCode.Space))
            body.velocity = new Vector2(body.velocity.x, Jump);
    }
}