using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saltar : MonoBehaviour
{
    private Animator animator;
    public float fuerzaSalto = 300f; // Fuerza con la que se aplicará el salto

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Verificar si se presionó la tecla de espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Activar la animación de salto
            animator.SetTrigger("Jump");

            // Saltar aplicando una fuerza al Rigidbody2D
            Rigidbody2D rb2D = GetComponent<Rigidbody2D>();
            rb2D.velocity = new Vector2(rb2D.velocity.x, fuerzaSalto);
        }
    }
}
