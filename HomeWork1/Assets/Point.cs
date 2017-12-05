using UnityEngine;
using System.Collections;

public class Point : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb2D1;
   
    float xMove, yMove;
   

    void Start()
    {
        rb2D1 = GetComponent<Rigidbody2D>();
        rb2D1.velocity = transform.forward * speed;
    }
    private void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            xMove = speed * Time.deltaTime;
            yMove = 0;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            xMove = -speed * Time.deltaTime;
            yMove = 0;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            yMove = speed * Time.deltaTime;
            xMove = 0;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            yMove = -speed * Time.deltaTime;
            xMove = 0;
        }
        this.transform.Translate(new Vector2(xMove, yMove));


    }
}


     