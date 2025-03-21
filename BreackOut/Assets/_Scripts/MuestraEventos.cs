using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MuestraEventos : MonoBehaviour
{

    public event EventHandler EnCasoDeEspacïoPresionado;
    public UnityEvent MiEventoUnity;

    // Start is called before the first frame update
    void Start()
    {
        EnCasoDeEspacïoPresionado += EventoEscuchado;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            EnCasoDeEspacïoPresionado?.Invoke(this, EventArgs.Empty);
            MiEventoUnity.Invoke();
        }
    }

    public void EventoEscuchado(object sender, EventArgs e) {
        Debug.Log("el evento se escucho correctamente");

    }

    public void EventoUnityDisparado() {
        Debug.Log("el evento de Unity se disparo correctamente");
    }


}
