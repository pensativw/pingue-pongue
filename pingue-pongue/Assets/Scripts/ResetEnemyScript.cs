using UnityEngine;
using UnityEngine.UI;

public class ResetEnemyScript : MonoBehaviour
{

    public Text pontTxt;
    public int pont;

    void Update()
    {
        pontTxt.text = pont.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ball")) { pont += 1; }
        
    }
}
