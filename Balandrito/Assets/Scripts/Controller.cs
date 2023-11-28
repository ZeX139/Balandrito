using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class Controller : MonoBehaviour
{
    
    
    public float fuerzaImpulso = 1f;
    private Rigidbody2D rb;
    

    void Start()
    {
        //Obtenemos el Rigidbody
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        PruebaControl();
        transform.position = new Vector3(-4.52f, -2.96f, 0);
    }

    public void PruebaControl()
    {
       
        
            //Este es un giro más natural pero mas complicado de controlar, basado en impulsos
            //Prueba temporal de control sin input manager
            float rotacion = Input.GetAxis("Horizontal");

            //Calculamos la fuerza de rotacion
            float giro = -rotacion * fuerzaImpulso;

            //Aplicamos la fuerza
           rb.AddTorque(giro * Time.deltaTime);
        

        
    }
}