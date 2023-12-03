using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float velocity;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // MOVIMENTACAO DE PERSONA
        float inputY = Input.GetAxisRaw("Vertical1");
        rb.velocity=new Vector2(0, inputY) * velocity;


    }
}
