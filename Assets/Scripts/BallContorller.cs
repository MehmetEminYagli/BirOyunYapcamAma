using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallContorller : MonoBehaviour
{

    [SerializeField] private float ballspeed;
    [SerializeField] private bool isRight;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float jumpSpeed;
    [SerializeField] private bool isJump;
    [SerializeField] private float rotationspeed;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
        isJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        ballJumpControl();
    }
    private void FixedUpdate()
    {
        playerballmove();
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("SagDuvar"))
        {
            isRight = false;
            
        }
        else if (other.gameObject.CompareTag("SolDuvar"))
        {
            isRight = true;;
        }
        if (other.gameObject.CompareTag("Platform"))
        {
            isJump = false;
        }
    }

    void playerballmove()
    {
        if (!isRight)
        {
            transform.position -= Vector3.right * ballspeed * Time.fixedDeltaTime;
            RotateBall(rotationspeed);
        }
        else
        {
            transform.position += Vector3.right * ballspeed * Time.fixedDeltaTime;
            RotateBall(-rotationspeed);
        }
        
    }
    private void ballJumpControl()
    {
        if (Input.GetMouseButtonDown(0))
        {
           ballJump();
        }
    }
    private void ballJump()
    {
        if (!isJump)
        {
            rb.velocity = new Vector2(rb.velocity.y, jumpSpeed);
            isJump = true;
        } 
    }

    private void RotateBall(float RotationAmount)
    {
        Vector3 currentRotation = transform.rotation.eulerAngles;
        currentRotation.z += RotationAmount * Time.fixedDeltaTime;
        transform.rotation = Quaternion.Euler(currentRotation);
    }
}



