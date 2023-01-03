using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    Animator animator;
    int frenteParam;
    int atrasParam;
    float speed = 3.0f; // Velocidad de movimiento del personaje

    void Start()
    {
        animator = GetComponent<Animator>();
        frenteParam = Animator.StringToHash("Frente");
        atrasParam = Animator.StringToHash("Atras");
    }

    void Update()
    {
        // Mueve al personaje hacia delante mientras la animación de caminar esté activa
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
    }
}