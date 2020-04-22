using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionsButton : MonoBehaviour
{
    public Text texto;
    public string textoIngles;
    public string textoEspanol;

    void Start()
    {
        int valor = PlayerPrefs.GetInt("LenguajeGuardado", 0);

        if (valor == 0)
            this.texto.text = this.textoIngles;
        else
            this.texto.text = this.textoEspanol;
    }

}
