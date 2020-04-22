using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImageLanguage : MonoBehaviour
{
    public Texture imagenEspanol;
    public Texture imagenIngles;
    public RawImage imagenCorrespondiente;

    void Start()
    {
        int valor = PlayerPrefs.GetInt("LenguajeGuardado", 0);

        if(valor == 0)
        {
            //0 es en Ingles
            this.imagenCorrespondiente.texture = this.imagenIngles;
        }
        else
        {
            //1 en Español
            this.imagenCorrespondiente.texture = this.imagenEspanol;
        }
    }

}
