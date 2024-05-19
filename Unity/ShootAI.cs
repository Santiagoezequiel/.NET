using System.Collections;
using UnityEngine;

public class ShootAI : MonoBehaviour
{

    [SerializeField] private GameObject proyectil;
    [SerializeField] private float timeShoot;
    void Start()
    {
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeShoot);
            Instantiate(proyectil, transform.position, Quaternion.identity); 
        }
    }
}
