using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSway : MonoBehaviour
{

    private Quaternion startRotation;

    public float swayAmmount = 8f;

    // Start is called before the first frame update
    void Start()
    {
        startRotation = transform.localRotation;
        
    }

    // Update is called once per frame
    void Update()
    {
        Sway();
    }

    private void Sway()
    {

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        Quaternion xAngle = Quaternion.AngleAxis(mouseX * -1.25f, Vector3.up);
        Quaternion yAngle = Quaternion.AngleAxis(mouseX * -1.25f, Vector3.right);

        Quaternion targetRotation = startRotation * xAngle * yAngle;

        transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, Time.deltaTime * swayAmmount);

    }


}
