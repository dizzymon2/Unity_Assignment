using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    public float speed;
    float xMove, yMove;
    Rigidbody2D rb2D;

    // Use this for initialization
    void Start () {
        rb2D = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        xMove = 0;
        yMove = 0;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            xMove = speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
            xMove = -speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.UpArrow))
            yMove = speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.DownArrow))
            yMove = -speed * Time.deltaTime;
        this.transform.Translate(new Vector2(xMove, yMove));


    }
}
