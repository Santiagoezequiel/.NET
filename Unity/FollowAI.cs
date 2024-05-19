using UnityEngine;

public class FollowAI : MonoBehaviour
{
    // Selecciono al jugador que seguirá con la mirada
    [SerializeField] private Transform player;
    [SerializeField] private float minDistance;
    [SerializeField] private float speed;

    // Está mirando a la derecha es true por que vamos a empezar estando a la derecha
    private bool isFacingRight = true;

    void Update()
    {
        Follow();

        // El jugador estará a la derecha si su posicion en x es mayor que nuestra posicion (En ese caso será true)
        bool isPlayerRight = transform.position.x < player.transform.position.x;
        // Ejecutamos constantemente la funcion flip
        Flip(isPlayerRight);
    }

    private void Follow()
    {
        if (Vector2.Distance(transform.position, player.position) > minDistance)
        {
            // Cambiamos posicion        Moverce hacia(desde,hacia donde, velocidad)
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else
        {
            Attack();
        }
    }

    private void Flip(bool isPlayerRight)
    {   // Si estamos mirando a la derecha y el jugador está a la izquierda, o si estamos mirando a la izquierda y el jugador esta a la derecha
        // Realizará un flip
        if((isFacingRight && !isPlayerRight) || (!isFacingRight && isPlayerRight))
        {
            isFacingRight = !isFacingRight;     // Cambiamos el estado de "Está mirando a la derecha"
            Vector3 scale = transform.localScale; // Creamos "scale"
            scale.x *= -1;                        // Invertimos la orientacion
            transform.localScale = scale;          // Aplicamos
        }
    }

    private void Attack()
    {
        Debug.Log("Ataque");
    }
}
