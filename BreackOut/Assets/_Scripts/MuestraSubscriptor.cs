using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuestraSubscriptor : MonoBehaviour
{
    MuestraEventos subscriptor; 

    // Start is called before the first frame update
    void Start()
    {
        subscriptor = GetComponent<MuestraEventos>(); 
        subscriptor.EnCasoDeEspac�oPresionado += MensajeEscucadoPorElSubscriptor;  //-= subscribirse
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void  MensajeEscucadoPorElSubscriptor(object sender, EventArgs e)
    {
        Debug.Log("el evento se escucho correctamente desde el subscriptor en otra clase");
        subscriptor.EnCasoDeEspac�oPresionado -= MensajeEscucadoPorElSubscriptor;   //-= dessuscibirse
    }


}
