using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [HideInInspector]
    public bool needPatrol;
    private bool needTurn;

    public float walkSpeed;

    public Rigidbody2D rb;
    public Transform groundCheckPos;
    public LayerMask groundLayer;

    void Start()
    {
        needPatrol = true;
    }

    void Update()
    {
        if (needPatrol)
        {
            Patrol();
        }
        if(transform.position.y < -31)
        {
            Destroy(this.gameObject);
        }
    }

    private void FixedUpdate()
    {
        if (needPatrol)
        {
            needTurn = !Physics2D.OverlapCircle(groundCheckPos.position, 0.1f, groundLayer); 
        }
    }

    void Patrol()
    {
        if (needTurn)
        {
            Flip();
        }

        rb.velocity = new Vector2(walkSpeed * Time.fixedDeltaTime, rb.velocity.y);
    }

    void Flip()
    {
        needPatrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        walkSpeed *= -1;
        needPatrol = true;
    }

}
