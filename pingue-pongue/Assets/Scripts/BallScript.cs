using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private float velocityX;
    private float velocityY;

    private const string PLAYER_TAG = "Player";
    private const string WALL_TAG = "Wall";
    private const string RESPAWN_TAG = "Respawn";


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velocityX = Random.Range(3, 4);
        velocityY = Random.Range(-0.25f,0.25f);
    }
    void Update()
    {
        rb.velocity = new Vector2(velocityX,velocityY);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag(PLAYER_TAG))
        {
            //Debug.Log("COLISÃO DE PLAYER");
            velocityX = -velocityX;
            velocityX *= 1.05f;
            velocityX = Mathf.Clamp(velocityX, -10, 10);

            velocityY *= 1.5f;
            velocityY = Mathf.Clamp(velocityY, -3, 3);
            rb.velocity = new Vector2(velocityX, velocityY);
            Debug.Log("velocityY = " + velocityY);
            Debug.Log("velocityX = " + velocityX);
        }
        else if (collision.collider.CompareTag(WALL_TAG))
        {
            //Debug.Log("COLISÃO DE PAREDE");
            velocityY = -velocityY;
        }
        else if (collision.collider.CompareTag(RESPAWN_TAG))
        {
            transform.position = Vector2.zero;
            velocityY = Random.Range(0.1f, 0.25f);
            velocityX = Random.Range(3, 4);
            Debug.Log("velocityY = " + velocityY);
        }
    }

}
