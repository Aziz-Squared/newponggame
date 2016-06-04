using UnityEngine;
using System.Collections;

public class ballMovement : MonoBehaviour {

    public float force = 4.5f;
    Rigidbody rb;

    private Vector3 vel;

    public void changeVel(Vector2 mod)
    {
        vel += new Vector3(mod.x, mod.y, 0);
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        vel = new Vector3(force, force, 0);
    }

    void Update()
    {
        transform.position += vel * Time.deltaTime;
    }

    public void Reset()
    {
        // reset the ball position and restart the ball movement
        rb.velocity = Vector2.zero;
        transform.position = new Vector3(0, 0, 0);
        Start(); // restart the ball 
    }
}
