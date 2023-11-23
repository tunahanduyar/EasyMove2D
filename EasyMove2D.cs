using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour
{

   
    private Rigidbody2D rb;
    private bool moveLeft;
    private bool moveRight;
    private float horizontalMove;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        moveLeft = false;
        moveRight = false;
    }

    public void PointerDownLeft()
    {
        moveLeft = true;
    }

    public void PointerUpLeft()
    {
        moveLeft = false;
    }

    public void PointerDownRight()
    {
        moveRight = true;
    }

    public void PointerUpRight()
    {
        moveRight = false;
    }


    void Update()
    {
        MovePlayer();

        }


        void MovePlayer()

        {
            if (moveLeft)
            {
                horizontalMove = -speed;
            }
            else if (moveRight)
            {
                horizontalMove = speed;
            }
            else
            {
                horizontalMove = 0;
            }
        }

        void FixedUpdate()
        {
            rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
        }
    }
