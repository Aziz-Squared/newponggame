using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    public int direction;
    private float moveX;
    private float moveY;

    public int playerNumber;

    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics2D.gravity = Vector2.zero;
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        if (playerNumber == 1)
        {
            if (Input.GetKey("w"))
            {
                //rigidbody2D.velocity = new Vector3(transform.position.x, transform.position.y, speed);
                rb.velocity = new Vector3(0, speed, 0);
            }
            if (Input.GetKey("s"))
            {
                //transform.position = new Vector3(transform.position.x, transform.position.y, -speed);
                rb.velocity = new Vector3(0, -speed, 0);
            }
        }
        if (playerNumber == 2)
        {
            if (Input.GetKey("o"))
            {
                transform.position += new Vector3(0, speed, 0);
            }
            if(Input.GetKey("l"))
            {
                transform.position += new Vector3(0, -speed, 0);
            }
        }
    }
    void OnCollisionEnter(Collision other)
    {
        float adjust = 5 * direction;
        other.rigidbody.velocity = new Vector2(other.rigidbody.velocity.x, other.rigidbody.velocity.y + adjust);
    }
}
