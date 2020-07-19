using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{

    public Transform radioFollowingPoint;

    public Transform centerMap;

    public Radio followingRadio;

    public KeyCode up, down, left, right;

    private Rigidbody2D rb;

    public int moveSpeed;

    // Start is called before the first frame update
    void Start()
    {

        rb=GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(up))
        {
            rb.velocity = new Vector3(rb.velocity.x, moveSpeed, 0.0f);
        }
        else if (Input.GetKey(down)) {
            rb.velocity = new Vector3(rb.velocity.x, -moveSpeed, 0.0f);
        }

        else if (Input.GetKey(left))
        {
            rb.velocity = new Vector3(-moveSpeed, rb.velocity.y, 0.0f);
        }
        else if (Input.GetKey(right))
        {
            rb.velocity = new Vector3(moveSpeed, rb.velocity.y, 0.0f);
        }
        else
        {
            rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
        }
        /*
        if (Input.GetKey(up)|| Input.GetKey(down) || Input.GetKey(left) || Input.GetKey(right))
        {

            Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
            Vector3 vertical = new Vector3(0.0f, Input.GetAxis("Vertical"), 0.0f);

            transform.position = (transform.position + Time.deltaTime * (horizontal + vertical));
        }
        */
    }
}
