using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    private bool isFollowing;

    public float followSpeed;

    public Transform followTarget;

    private BasicMovement thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isFollowing)
        {
            transform.position = Vector3.Lerp(transform.position, followTarget.position, followSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bob")
        {
            if (!isFollowing)
            {
                thePlayer = GameObject.FindGameObjectWithTag("Bob").GetComponent<BasicMovement>();

                followTarget = thePlayer.radioFollowingPoint;

                isFollowing = true;
                thePlayer.followingRadio = this; 
            }
        }

        if (other.tag == "Doug")
        {
            if (!isFollowing)
            {
                thePlayer = GameObject.FindGameObjectWithTag("Doug").GetComponent<BasicMovement>();

                followTarget = thePlayer.radioFollowingPoint;

                isFollowing = true;
                thePlayer.followingRadio = this;
            }
        }
    }
}
