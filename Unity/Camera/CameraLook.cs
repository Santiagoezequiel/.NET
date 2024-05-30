using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public float mouseSensitivy = 80f;

    public Transform playerBody;

    float xRotation = 0f;

    void Start()
    {
    
        // Ocultar y bloquear el cursor
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivy * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivy * Time.deltaTime;


        // Aplicar rotación en el eje X

        xRotation -= mouseY;                                // Para invertir la rotacion vertical cambia de + a -
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Aplicar la rotación al objeto de la cámara
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        // Rotar el cuerpo del jugador en el eje Y
        playerBody.Rotate(Vector3.up * mouseX);
    }









}
