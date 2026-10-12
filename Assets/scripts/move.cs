using UnityEngine;
using TMPro;

public class move : MonoBehaviour
{
    public bool invert = false;
    public TMP_Text rocktext;
    public int rocks = 7;
    public TMP_Text healthtxt;
    public int health = 7;
    public float speed = 7;
    public Rigidbody2D playerrb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthtxt.text = ("") + health;
        rocktext.text = ("") + rocks;
    }

    // Update is called once per frame
    void Update()
    {
        if(invert == true)
        {
            
        }
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
            
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            rocks = rocks - 1;
            rocktext.text = ("") + rocks;
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
