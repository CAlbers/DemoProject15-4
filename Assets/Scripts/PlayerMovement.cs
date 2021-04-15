using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private float movementSpeed;
    [SerializeField]
    private float maxSpeed;

    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Old input system
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        float verticalAxis = Input.GetAxisRaw("Vertical");

        //Normalize to not get 1,4x speed diagonal
        Vector2 direction = new Vector2(horizontalAxis, verticalAxis).normalized;
        //Check if there is any movement else set velocity on 0
        if (direction != Vector2.zero)
        {
            rb2d.AddForce(direction * movementSpeed);
            rb2d.velocity = Vector2.ClampMagnitude(rb2d.velocity, maxSpeed);
        }
        else
            rb2d.velocity = Vector2.zero;

    }
}
