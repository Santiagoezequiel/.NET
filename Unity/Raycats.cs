using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycats : MonoBehaviour
{








    // SerializeField hace que se pueda modificar desde el cliente aunque sea privada
    [SerializeField] private LayerMask whatToDetecte;

    void Update()
    {
        /////////////////////RAYCATS 3D//////////////////////////////////////

        float maxDistance = 0.7f;

        RaycastHit hit;                                                     // DECLARAMOS EL HIT
        Ray ray = new Ray(transform.position, Vector3.down);                // CREAMOS UN RAY
        Debug.DrawRay(ray.origin, Vector3.down * 0.5f, Color.red);          // HACEMOS EL RAY VISIBLE

        if (Physics.Raycast(ray, out hit, maxDistance, whatToDetecte))
        {
            Debug.Log("Distancia: " + hit.distance);
            Debug.Log("Impacto : " + hit.point);
            hit.transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;   // LO QUE HARÁ SI IMPACTA CON UN OBJET

        }


        /////////////////////RAYCATS 2D//////////////////////////////////////

        RaycastHit2D hit2;
        Ray ray2 = new Ray(transform.position, Vector2.down);
        Debug.DrawRay(ray2.origin, Vector2.down * 0.5f, Color.red);

        hit2 = Physics2D.Raycast(transform.position, Vector2.down, 0.7f);
        if (hit.collider != null)
        {
            Debug.Log("Distancia: " + hit.distance);
            Debug.Log("Impacto : " + hit.point);
            hit.transform.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }

    }
}
