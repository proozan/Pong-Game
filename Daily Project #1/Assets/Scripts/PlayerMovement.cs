using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float Speed;
    public Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity += new Vector2(moveX * Speed * Time.deltaTime, 0);
    }

}
