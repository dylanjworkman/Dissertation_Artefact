using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 5;
    public Rigidbody rb;

    private void FixedUpdate()
    {
        Vector3 leftMove = -transform.right * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + leftMove);
    }

     private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
