using UnityEngine;
using TMPro;

public class move : MonoBehaviour
{
    public float checkRad = 1.5f;
    public LayerMask Default;
    private Vector2 direct = Vector2.up;
    public GameObject rock;
    public float rockSpeed = 15f;
    public bool invert = false;
    public int rocks = 7;
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
        //if(playerrb.linearVelocity.magnitude > 0.1f)
        //{
            //direct = playerrb.linearVelocity.normalized;
        //}
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        if(h != 0 || v != 0)
        {
            direct = new Vector2(h,v).normalized;
        }
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
            Vector2 spawnPos = (Vector2)transform.position + direct * 1f;
            GameObject rockIns = Instantiate(rock, spawnPos, Quaternion.identity);
            Physics2D.IgnoreCollision(rockIns.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            rockIns.GetComponent<Rigidbody2D>().linearVelocity = direct * rockSpeed;
            rocks = rocks - 1;
            Destroy(rockIns, 3f);



            //Collider2D hit = Physics2D.OverlapCircle(transform.position, checkRad, Default);
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
        //if(collision.gameObject.name.Contains("rock"))
        //{
            //Destroy(collision.gameObject);
            //Debug.Log("rockhit");
        //}
    }
    
}
