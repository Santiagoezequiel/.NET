using System.Collections.Generic;
using UnityEngine;

public class SequencePlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private bool isFacingRight = true;


    private List<Vector2> waypoints = new List<Vector2>();
    private Vector2 newWaypoint;
    private Camera cam;


    void Start()
    {
        cam = Camera.main;
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            newWaypoint = cam.ScreenToWorldPoint(Input.mousePosition);
            waypoints.Add(newWaypoint);
        }

        Move();

        Flip();
    }


    private void Flip()
    {
        if (waypoints.Count == 0) // Ppara evitar errores cuando la lista está vacía
        {
            return;
        }

        if ((waypoints[0].x < transform.position.x && isFacingRight) || (waypoints[0].x > transform.position.x && !isFacingRight))
        {
            isFacingRight = !isFacingRight;
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
        }

    }

    private void Move()
    {
        if (waypoints.Count == 0) 
        {
            return;
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[0], speed * Time.deltaTime);

        if ((Vector2)transform.position == waypoints[0])   // Transform.position es vector3 y wayponts vector 2, por eso hay que convertirlo para poder compararlos
        {
            waypoints.RemoveAt(0);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;

        foreach (Vector2 waypoint in waypoints)
        {
            Gizmos.DrawSphere(waypoint, 0.1f);
        
        }
    }
}
