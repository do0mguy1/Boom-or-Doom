using UnityEngine;

public class wheelguyscrt : MonoBehaviour
{
    public GameObject player;
    public float speed = 5;
    public Rigidbody2D wheel;
    public float healtht = 5;
    public float mindistance = 0f;
    public float maxdistance = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float currentdistance = Vector3.Distance(transform.position,player.transform.position);
        if(currentdistance<= maxdistance&&currentdistance>=mindistance)
        {
            transform.LookAt(new Vector3(player.transform.position.x,transform.position.y));
            transform.position+=transform.forward*speed*Time.deltaTime;
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
    //gos to hit player
    //gets hit
    //anger intesifis
    //trys again
    //gets hit 5 times
    //dies
}
