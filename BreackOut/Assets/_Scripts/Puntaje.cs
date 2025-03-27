using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{

    public Transform transformPuntajeAlto;
    public Transform transformPuntajeActual;
    public TMP_Text textoPuntajeALto;
    public TMP_Text textoPuntajeActual;
    //public int puntos = 0;
    //public int puntajeAlto = 100000;
    public PuntajeAlto puntajeAltoSO;

    // Start is called before the first frame update
    void Start()
    {
        transformPuntajeActual = GameObject.Find("PuntajeActual").transform;
        transformPuntajeAlto = GameObject.Find("PuntajeAlto").transform;
        textoPuntajeActual = transformPuntajeActual.GetComponent<TMP_Text>();
        textoPuntajeALto = transformPuntajeAlto.GetComponent<TMP_Text>();

        puntajeAltoSO.Cargar();
        textoPuntajeALto.text = $"PuntajeAlto: {puntajeAltoSO.puntaje}";
        puntajeAltoSO.puntaje = 0;

        //if (PlayerPrefs.HasKey("PuntajeAlto"))
        //{
            //puntajeAlto = PlayerPrefs.GetInt("PuntajeAlto");
        //    textoPuntajeALto.text = $"PuntajeAlto: {puntajeAltoSO.puntaje}";
        //}

    }

    private void FixedUpdate()
    {
        puntajeAltoSO.puntaje += 50;
    }

    // Update is called once per frame
    void Update()
    {
        textoPuntajeActual.text = $"PuntajeActual: {puntajeAltoSO.puntaje}";
        if(puntajeAltoSO.puntaje > puntajeAltoSO.puntajeAlto)
        {
            puntajeAltoSO.puntajeAlto = puntajeAltoSO.puntaje;
            textoPuntajeALto.text = $"PuntajeAlto: {puntajeAltoSO.puntaje}";
            puntajeAltoSO.Guardar();
            //PlayerPrefs.SetInt("PuntajeAlto", puntos);
        }
    }
}
