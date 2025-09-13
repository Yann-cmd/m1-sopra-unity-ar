using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class ClickRotate : MonoBehaviour
{
    [Header("Clic simple")]
    public float rotationSpeed = 100f;
    public float tiltAngle = 30f;
    public float bounceHeight = 0.2f;
    public float bounceSpeed = 3f;

    private Quaternion baseRotation;

    private bool animateLeft = false;

    void Start()
    {
        // Sauvegarde la rotation et la position initiale
        baseRotation = transform.localRotation;
    }

    void Update()
    {
        // Détection clic droit
        if (Mouse.current != null && Mouse.current.rightButton.wasPressedThisFrame)
        {
            Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.transform == transform)
                {
                    animateLeft = !animateLeft;
                }
            }
        }

        // Animation clic simple : tilt + rebond
        if (animateLeft)
        {
            float tilt = Mathf.Sin(Time.time * 3f) * tiltAngle;
            //transform.localRotation = Quaternion.Euler(-90 + tilt, 0, 0);
            Quaternion tiltRotation = Quaternion.Euler(tilt, 0, 0);
            transform.localRotation = baseRotation * tiltRotation;

            Vector3 bounce = transform.position;
            bounce.z += Mathf.Sin(Time.time * bounceSpeed) * bounceHeight;
            transform.position = bounce;
        }
    }
}