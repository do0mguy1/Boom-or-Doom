using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Security.Cryptography.X509Certificates;

public class randmove : MonoBehaviour
{
    public float pspeed = 2500;
    public float nottimer;
    public float notinterval = 1f;
    public GameObject ran;
    public float healtht = 5;
    public float timer;
    public float interval = 1f;
    public float tr;
    public TMP_Text random;
    public bool randa = false;
    public float speed = 5;
    public Rigidbody2D playerrb;
    // Start is called before the first frame update
    void Start()
    {
        random.text = ("");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        nottimer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.T))
        {
            randa = true;
        }
        if (randa == true)
        {

        }
        if (timer >= interval)
        {
            int randomNumber = Random.Range(0, 4);
            timer = 0f;

            random.text = ("") + randomNumber;



            if (randomNumber == 0)
            {
                playerrb.AddRelativeForce(Vector3.up * speed);
                Debug.Log("w");
            }

            if (randomNumber == 1)
            {
                playerrb.AddRelativeForce(Vector3.left * speed);
                Debug.Log("a");
            }

            if (randomNumber == 2)
            {
                playerrb.AddRelativeForce(Vector3.right * speed);
                Debug.Log("d");
            }

            if (randomNumber == 3)
            {
                playerrb.AddRelativeForce(Vector3.down * speed);
                Debug.Log("s");
            }
        }
        if (nottimer >= notinterval)
        {
            int randomNumber2 = Random.Range(0, 3);
            nottimer = 0f;




            if (randomNumber2 == 0)
            {
                playerrb.AddRelativeForce(Vector3.up * speed);
            }

            if (randomNumber2 == 1)
            {
                playerrb.AddRelativeForce(Vector3.left * speed);
            }

            if (randomNumber2 == 2)
            {
                playerrb.AddRelativeForce(Vector3.right * speed);
            }
        }
    }




    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("touch"))
        {
            healtht = healtht - 0;
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
        if (collision.gameObject.CompareTag("nohit"))
        {
            playerrb.AddRelativeForce(Vector3.back * pspeed);
        }
    }



}
