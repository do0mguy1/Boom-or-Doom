using UnityEngine;

public class dummy : MonoBehaviour
{
    public float healtht = 5;
    public float pspeed = 2500;
    public Rigidbody2D playerrb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
            Debug.Log("dummy hit");
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
        if (collision.gameObject.CompareTag("nohit"))
        {
            playerrb.AddRelativeForce(Vector3.back * pspeed);
        }
    }



}


