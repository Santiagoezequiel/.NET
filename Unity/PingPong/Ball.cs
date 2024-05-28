using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float initialVelocity = 4f;
    [SerializeField] private float multiplier = 1f;
    private Rigidbody2D ballRb;

    // Start is called before the first frame update
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        Launch();
    }

    private void Launch()
    {
        float xVelocity = Random.Range(0,2) == 0 ? 1 : -1;
        float yVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        ballRb.velocity = new Vector2(xVelocity,yVelocity) * initialVelocity;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            ballRb.velocity *= multiplier;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Goal1"))
        {
            StartCoroutine(Goal1True());
        }
        else
        {
            StartCoroutine(Goal1False());
        }

    }


    private IEnumerator Goal1True()
    {
        GameManager.Instance.Paddle2Score();
        GameManager.Instance.Restart();
        ballRb.velocity = Vector2.zero;
        yield return new WaitForSeconds(1);
        Launch();
    }

    private IEnumerator Goal1False()
    {
        GameManager.Instance.Paddle1Score();
        GameManager.Instance.Restart();
        ballRb.velocity = Vector2.zero;
        yield return new WaitForSeconds(1);
        Launch();
    }
}
