using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{


    // SerializeField hace que se pueda modificar desde el cliente aunque sea privada
    [SerializeField] private LayerMask whatToDetecte;

    void Update()
    {


        /////////////////////RAYCATS 3D//////////////////////////////////////

        float maxDistance = 30f;

        RaycastHit hit;                                                     // DECLARAMOS EL HIT
        Ray ray = new Ray(transform.position, transform.forward);                // CREAMOS UN RAY
        Debug.DrawRay(ray.origin, ray.direction * maxDistance, Color.red);          // HACEMOS EL RAY VISIBLE

        if (Physics.Raycast(ray, out hit, maxDistance, whatToDetecte, QueryTriggerInteraction.Ignore))
        {
            Debug.Log("Distancia: " + hit.distance);
            Debug.Log("Impacto : " + hit.point);
            hit.transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;   // LO QUE HARÁ SI IMPACTA CON UN OBJET

        }

    }  
}
