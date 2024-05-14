using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{




    private Rigidbody2D rigidbody2d;
    private Animator animator;

    public float fuerzaSalto;
    public float speed;
    float Horizontal;
    private bool Grounded;




    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2d = GetComponent<Rigidbody2D>();
    }


    void Update()
    {



        Horizontal = Input.GetAxisRaw("Horizontal");

        if (Horizontal < 0.0f) transform.localScale = new Vector3 (-1.0f, 1.0f, 1.0f);
        else if (Horizontal > 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        animator.SetBool("runningTrue", Horizontal != 0.0f);

        ////////////////////// Detectar suelo  ///////////////////////////////////////////////


        //        Ray ray = new Ray(origen, direccion);         Asi se crea un raycast

        RaycastHit2D hit;
        Ray ray = new Ray(transform.position, Vector2.down);
        Debug.DrawRay(ray.origin, Vector2.down * 0.5f, Color.red);

        hit = Physics2D.Raycast(transform.position, Vector2.down, 0.7f);
        if (hit.collider != null)
        {
            Debug.Log("Distancia: " + hit.distance);
            Debug.Log("Impacto : " + hit.point);
            hit.transform.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
        /*{        if (Physics2D.Raycast(transform.position, Vector3.down, 0.1f))
                {
                    Grounded = true;
                }
                else Grounded = false;}*/

        if (Input.GetKeyDown(KeyCode.Space) && Grounded == true)
        {
            Jump();
        }

    }


    private void FixedUpdate()
    {
        rigidbody2d.velocity = new Vector2(Horizontal * speed, rigidbody2d.velocity.y );
    }

    private void Jump()
    {                                                   // SALTAR
            animator.SetBool("jumpingTrue", true);
            rigidbody2d.AddForce(Vector2.up * fuerzaSalto);
    }





    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            animator.SetBool("jumpingTrue", false);

        }
    }
}
