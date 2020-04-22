using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsSpanishEnglish : MonoBehaviour
{
    public Text textLanguage;
    private int valor;
    private string texto;

    void Start()
    {
        valor = PlayerPrefs.GetInt("LenguajeGuardado", 0);        
        texto = "";
    }

    void Update()
    {
        if (valor == 0)
            texto = "* Andrea Massimino (Game Designer & Artist) \n\n" +
                    "* Daniela Rosales (Producer & Artist)  \n\n" +
                    "* Laura Velazquez (Programmer Back End) \n\n" +
                    "* Sergio Garzón (Programmer Front End)";
        else
            texto = "* Andrea Massimino (Game Designer - Artista) \n\n" +
                    "* Daniela Rosales (Productora - Artista) \n\n" +
                    "* Laura Velazquez (Prograadora Back End) \n\n" +
                    "* Sergio Garzón (Programador Front End)";


        this.textLanguage.text = texto;
    }



}
