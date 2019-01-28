using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletePlayerController : MonoBehaviour
{
    private float verticalVelocity;
    public float speed;
    private Rigidbody2D rb2d;
    private int desiredLane = 1; //0 = left, 1= mid, 2 = right

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        if (Input.GetKey(KeyCode.D))
            MoveLane(false);
        if (Input.GetKey(KeyCode.A))
            MoveLane(true);
    }

    private void MoveLane(bool goingRight)
    {
        //left
        if (!goingRight)
    }

}
