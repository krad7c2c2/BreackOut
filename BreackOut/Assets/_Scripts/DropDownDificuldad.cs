using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownDificuldad : MonoBehaviour
{

    public Opciones opciones; //referencia scriptable object
    private Dropdown dificultad;

    private void Start()
    {
        dificultad = GetComponent<Dropdown>();
        dificultad.onValueChanged.AddListener(delegate { opciones.CambiarDificultad(dificultad.value); }); //delegado(lista de funciones) cambia la dificultad
    }


}
