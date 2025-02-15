using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D rbBall;
    public float moveSpeed = 1f;

    int score = 0;
    int lives = 3;

    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI livesTxt;


    private void Start()
    {
        rbBall = GetComponent<Rigidbody2D>();
        InitialPush();
    }

    public void InitialPush()
    {
        Vector2 dir = Vector2.left;
        dir.y = -0.67f;
        rbBall.linearVelocity = dir * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Brick"))
        {
            Destroy(collision.gameObject);
            score += 1;
            scoreTxt.text = score.ToString("Score: 0");
            
        }
        else if (collision.gameObject.CompareTag("Finish"))
        {
            lives -= 1;
            livesTxt.text = "Lives: " + lives.ToString();
             if (lives < 1)
            {
            Destroy(gameObject);
            }

        }
    }
}

