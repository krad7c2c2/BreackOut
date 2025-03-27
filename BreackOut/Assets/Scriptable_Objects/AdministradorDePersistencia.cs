using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorDePersistencia : MonoBehaviour
{

    public List<PuntajePersistente> ObjetoGuardar;

    private void OnEnable()
    {
        for(int i = 0; i < ObjetoGuardar.Count; i++)
        {
            var so = ObjetoGuardar[i];
            so.Cargar();
        }
    }

    private void OnDisable()
    {
        for (int i = 0; i < ObjetoGuardar.Count; i++)
        {
            var so = ObjetoGuardar[i];
            so.Guardar();
        }
    }


}
