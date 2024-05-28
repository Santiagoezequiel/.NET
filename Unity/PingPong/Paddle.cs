using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Paddle : MonoBehaviour
{

    [SerializeField] private float speed = 7f;
    [SerializeField] private bool isPaddle1;
    [SerializeField] private float yRange = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movement;

        if (isPaddle1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }

        

        Vector2 paddlePosition = transform.position;
        paddlePosition.y = Mathf.Clamp(paddlePosition.y + movement * speed * Time.deltaTime, -yRange, yRange);

        transform.position = paddlePosition;

    }
}
