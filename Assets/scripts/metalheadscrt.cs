using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class metalheadscrt : MonoBehaviour
{
    public float interval = 1;
    public float timer;
    public TMP_Text metaltxt;
    public Rigidbody2D metalrb;
    public float HeadMetalCount = 0;
    public float speed = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        metaltxt.text = ("");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= interval)
        {
            timer = 0;
            metaltxt.text = ("") + HeadMetalCount;

            if (0f <= HeadMetalCount && HeadMetalCount <= 2f)
            {
                metalrb.AddRelativeForce(Vector3.right * speed);
                HeadMetalCount = HeadMetalCount + 1f;
            }
            else if (HeadMetalCount == 3f)
            {
                metalrb.AddRelativeForce(Vector3.up * speed);
                HeadMetalCount = HeadMetalCount + 1f;
            }
            else if (4f <= HeadMetalCount && HeadMetalCount <= 6f)
            {
                metalrb.AddRelativeForce(Vector3.left * speed);
                HeadMetalCount = HeadMetalCount + 1f;
            }
            else if (HeadMetalCount == 7f)
            {
                metalrb.AddRelativeForce(Vector3.down * speed);
                HeadMetalCount = 0f;
            }
        }
    }
}
