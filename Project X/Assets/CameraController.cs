using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // El objeto que seguirá la cámara
    public float smoothTime = 0.3f; // Tiempo de suavizado de la cámara
    public Vector3 offset; // Desplazamiento de la cámara respecto al objetivo

    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        // Calcula la posición deseada de la cámara
        Vector3 desiredPosition = target.position + offset;
        // Suaviza el movimiento de la cámara hacia la posición deseada
        transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothTime);
    }
}
