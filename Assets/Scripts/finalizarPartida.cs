using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class finalizarPartida : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ventanaAdvertencia;
    void Start()
    {
        if (ventanaAdvertencia != null)
        {
            ventanaAdvertencia.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void botonFinalizar()
    {
        ventanaAdvertencia.SetActive(true);
    }

    public void botonAceptar()
    {

        SceneManager.LoadScene("escenaPrincipal", LoadSceneMode.Single);
    }

    public void botonCancelar()
    {
        ventanaAdvertencia.SetActive(false);
    }
}
