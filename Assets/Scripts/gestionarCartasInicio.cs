using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gestionarCartasInicio : MonoBehaviour
{
    public GameObject carta0;
    public GameObject carta1;
    public GameObject carta2;
    public GameObject carta3;
    public GameObject carta4;
    public GameObject carta5;
    public GameObject carta6;
    public GameObject carta7;
    public GameObject carta8;
    public GameObject carta9;
    public GameObject carta10;
    public GameObject carta11;
    public GameObject carta12;
    public GameObject carta13;
    public GameObject carta14;
    public GameObject carta15;

    public Texture2D[] imagenes;


    // Start is called before the first frame update
    void Start()
    {
        barajarYMostrarCartas();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void barajarYMostrarCartas()
    {
       new WaitForSeconds(1);
        List<GameObject> cartas = cartasEnArray();

        List<int> numeros = new List<int>();
        for (int i = 0; i < cartas.Count; i++) {
            numeros.Add(i);
        }
        
        int aleatorio;
        int posicion;
        List<GameObject> barajadas = new List<GameObject>();

        while (numeros.Count > 0) {
            aleatorio = Random.Range(0, numeros.Count);
            posicion = numeros[aleatorio];
            numeros.RemoveAt(aleatorio);

            barajadas.Add(cartas[posicion]);

        }

        for (int i = 0; i < barajadas.Count; i++) {
            ponerImagen(barajadas[i], imagenes[i / 2]);

        }

    }

    void ponerImagen(GameObject objeto, Texture2D imagen)
    {
        objeto.GetComponent<MeshRenderer>().material.mainTexture = imagen;
    }


    List<GameObject> cartasEnArray()
    {
        List<GameObject> res = new List<GameObject>();
        res.Add(carta0);
        res.Add(carta1);
        res.Add(carta2);
        res.Add(carta3);
        res.Add(carta4);
        res.Add(carta5);
        res.Add(carta6);
        res.Add(carta7);
        res.Add(carta8);
        res.Add(carta9);
        res.Add(carta10);
        res.Add(carta11);
        res.Add(carta12);
        res.Add(carta13);
        res.Add(carta14);
        res.Add(carta15);
        return res;
    }

}
