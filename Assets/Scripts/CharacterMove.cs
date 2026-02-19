using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 3f;
    public Animator animator;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //transform.Translate(new Vector3(horizontal, 0, vertical) * Time.deltaTime * 5f);

        rb.velocity = new Vector3(horizontal * speed, rb.velocity.y, vertical * speed);
        if (rb.velocity.magnitude > 0.01f)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        if (horizontal > 0)
        {
            transform.GetChild(0).localScale = new Vector3(4.6f, 3.5f ,1f);
        }

        if (horizontal < 0)
        {
            transform.GetChild(0).localScale = new Vector3(-4.6f, 3.5f ,1f);
        }
    }
}
