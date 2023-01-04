using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    Animator animator;
    int frenteParam;
    int atrasParam;
    int derechaParam;
    float speed = 3.0f;
    float speedr = 90.0f; // Velocidad de rotación del personaje (en grados por segundo)
    float angle; // Ángulo de rotación actual

    void Start()
    {
        animator = GetComponent<Animator>();
        frenteParam = Animator.StringToHash("Frente");
        atrasParam = Animator.StringToHash("Atras");
        derechaParam = Animator.StringToHash("Derecha");
        angle = 0;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool(frenteParam, true);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else
        {
            animator.SetBool(frenteParam, false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool(atrasParam, true);
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        else
        {
            animator.SetBool(atrasParam, false);
        }

        if(Input.GetKey(KeyCode.D))
        {
            animator.SetBool(derechaParam, true);
            transform.Rotate(0, speedr * Time.deltaTime, 0);
            angle += speedr * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, angle, 0);
        }
        else
        {
            animator.SetBool(derechaParam, false);
        }
    }
}