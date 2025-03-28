using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{

    public GameObject MenuOpciones;
    public GameObject MenuInicial;


    public void IniciarJuago() {
        SceneManager.LoadScene(1);
    }

    public void FinalizarJuego()
    {
        Application.Quit();
    }

    public void MostrarOpciones() {
        MenuInicial.SetActive(false);
        MenuOpciones.SetActive(true);
    }

    public void MostrarMenuInicial()
    {
        MenuOpciones.SetActive(false);
        MenuInicial.SetActive(true);       
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
