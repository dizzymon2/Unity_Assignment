/*using UnityEngine;
using System.Collections;

public class SpriteMovement  : MonoBehaviour
{
    public float speed;
    public GameObject Sprite;
    float xMove, yMove;
    Rigidbody2D rb2D;



    void Start()
    {

        rb2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 touchPos =new Vector2(worldPos.x, worldPos.y);

            transform.position = touchPos;

            GameObject Clone = Instantiate(Sprite, transform.position, Quaternion.identity) as GameObject;

            Destroy(Sprite.gameObject, 0.1f);
        }
    }

    void FixedUpdate()
    {
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
}*/