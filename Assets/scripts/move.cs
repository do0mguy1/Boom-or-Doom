using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 7;
    public Rigidbody2D playerrb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
        if(Input.GetKey(KeyCode.Q))
        {

        }
        if(Input.GetKey(KeyCode.E))
        {

        }
    }
}
