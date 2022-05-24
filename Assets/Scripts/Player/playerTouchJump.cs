using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTouchJump : MonoBehaviour
{
    private Rigidbody rb;

    public float jumpForce = 400f;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            rb.AddForce(new Vector3(0f, jumpForce), ForceMode.Force);
        }
    }
}//&& rb.velocity.y == 0
