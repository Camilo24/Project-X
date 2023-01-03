using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public bool frente = false;
    Animator animator;
    int frenteParam;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        frenteParam = Animator.StringToHash("Frente");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            frente = true;
        }
        animator.SetBool(frenteParam, frente);
    }
}
