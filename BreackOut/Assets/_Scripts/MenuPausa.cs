using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{

    public GameObject menuPausa;
    public GameObject menuOpciones;

    public void MostarMenuPausa() {
        menuPausa.SetActive(true);
        if (menuOpciones.activeInHierarchy) menuOpciones.SetActive(false);
    }

    public void OcultarMenuPausa() {
        menuPausa.SetActive(false);
    }

    public void RegresaAPantallaPrincipal() {
        SceneManager.LoadScene(0);
    }

    public void MostarMenuOpciones() {
        menuPausa.SetActive(false);
        menuOpciones.SetActive(true);
    }
  
}
