using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private bool isFacingRight = true;

    private Vector2 target;
    private Camera cam;
    void Start()
    {
        cam = Camera.main;
        target = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = cam.ScreenToWorldPoint(Input.mousePosition);
        }

        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        Flip();
    }


    private void Flip()
    {
        if ((target.x < transform.position.x && isFacingRight) || (target.x > transform.position.x && !isFacingRight))
        {
            isFacingRight = !isFacingRight;
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
        }

    }
}
