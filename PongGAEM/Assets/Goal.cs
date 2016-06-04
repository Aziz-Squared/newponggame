using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {
        if (other.transform.name == "Ball")
        {
            GetComponent<ballMovement>().Reset();
        }
    }
}
