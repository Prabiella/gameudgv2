using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frog : MonoBehaviour
{
    public GameObject bullet;
    public float velocidad;
    public float fuerzaSalto;
    private Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        MovFrog();
        Saltar();
        Disparo();
    }

    void MovFrog()
    {
        float inputMov = Input.GetAxis("Horizontal");
        Rigidbody2D rb2D = GetComponent<Rigidbody2D>();
        rb2D.velocity = new Vector2(inputMov * velocidad, rb2D.velocity.y);
    }

    void Saltar()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");

            Rigidbody2D rb2D = GetComponent<Rigidbody2D>();
            rb2D.velocity = new Vector2(rb2D.velocity.x, fuerzaSalto);

        }
        else
        {
            animator.SetTrigger("stand");
        }
    }




    void Disparo()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }




}

