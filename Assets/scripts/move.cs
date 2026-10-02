using UnityEngine;
using TMPro;

public class move : MonoBehaviour
{
    public TMP_Text healthtxt;
    public int health = 7;
    public float speed = 7;
    public Rigidbody2D playerrb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthtxt.text = ("") + health;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {  
            playerrb.AddRelativeForce(Vector3.up * speed);
        }
        if(Input.GetKey(KeyCode.A))
        {
            playerrb.AddRelativeForce(Vector3.left * speed);
        }
        if(Input.GetKey(KeyCode.S))
        {
            playerrb.AddRelativeForce(Vector3.down * speed);
        }
        if(Input.GetKey(KeyCode.D))
        {
            playerrb.AddRelativeForce(Vector3.right * speed);
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            health = health - 1;
            healthtxt.text = ("") + health;
        }
        if(Input.GetKey(KeyCode.E))
        {

        }
        if(health == 0)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("enemy"))
        {
            health = health - 1;
            healthtxt.text = ("") + health;
        }
    }
}
