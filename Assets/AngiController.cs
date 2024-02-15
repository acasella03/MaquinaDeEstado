using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngiController : MonoBehaviour
{
    Animator animator;
    bool b_andar = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        b_andar=false;
    }

    // Update is called once per frame
    void Update()
    {
        // Verificar si se presionó la tecla espaciadora
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            // Imprimir un mensaje en la consola
            Debug.Log("Personaje está andando");

            b_andar = true;

            // Activar el estado de "Andar" en el Animator
            animator.SetBool("Andar", true);

        }

    }
}
