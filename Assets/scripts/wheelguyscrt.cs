using UnityEngine;

public class wheelguyscrt : MonoBehaviour
{
    public bool hit = false;
    public bool angy = false;
    public GameObject player;
    public float speed = 5;
    public Rigidbody2D wheel;
    public float healtht = 5;
    public float mindistance = 1f;
    public float maxdistance = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float currentdistance = Vector2.Distance(transform.position,player.transform.position);
        if(currentdistance <= maxdistance && currentdistance >= mindistance)
        {

            float step = speed * Time.deltaTime; 
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
            
        }
        if(angy == true)
        {
            speed = 3;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("hurt"))
        {
            Debug.Log("hit");
            healtht = healtht - 1;
            if (healtht <= 0)
            {
                Destroy(gameObject);
            }
            hit = true;
            if(hit == true)
            {
                angy = true;
            }
        }
        if (collision.gameObject.CompareTag("sword"))
        {
            healtht = healtht - 0;
            if (healtht <= 2)
            {
                healtht = healtht - 0;
            }
            if (healtht <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
    //go to hit player
    //get hit
    //anger intesifis
    //try again
    //get hit 4 times
    //die
}
