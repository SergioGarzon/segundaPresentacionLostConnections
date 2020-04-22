using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;

public class TextHistory : MonoBehaviour
{
    public UnityEngine.UI.Text textScene;
    private string texto;
    public UnityEngine.UI.Slider sldProgressBarChargeScene;

    void Awake()
    {
    }


    private void Start() {
        this.texto = "";

        int x = PlayerPrefs.GetInt("LenguajeGuardado", 0);

        if (x == 0)
        {
            this.texto = "3020 \n" +
                         "In a technology - based society with no apparent past, a never seen before crisis threatens the entire system.Swarms of viruses plague the city, absorb the energy which the new humanity depends, causing blackouts in the system." +
                         " Its origin? The Arbitrium headquarters, a company whose power has absorbed every" +
                         " branch of the system and society, becoming the highest governing authority." +
                         " Now, after the big explosion caused by the swarm, thousands of data from this company spread throughout the city." +
                         " What role will you play in the midst of chaos and crisis?" +
                         " Restores system power and collects this data to move forward and discover the" +
                         " story behind this new order.";
        }        
        else
        {
            this.texto = "Año 3020 \n" +
             "En una sociedad basada en la tecnología sin un pasado aparenten, una crisis jamás antes vista amenaza todo el sistema. Enjambres de virus azotan la ciudad,absorben la energía de la ciudad de la cual depende la nueva humanidad, provocando apagones en el sistema." +
             "¿Su origen? La central de Arbitrium, un compañía cuyo poder ha absorbido cada rama del sistema y la sociedad, convirtiéndose en la máxima autoridad regente. " +
             "Ahora, luego de la gran explosión causada por el enjambre, miles de datos provenientes de esta compañía se esparcen por la ciudad." +
             "¿Qué papel ocuparas tu en el medio del caos y la crisis? " +
             "Restaura la energía del sistema y recolecta estos datos para avanzar y descubrir la historia detrás de este nuevo orde.";
        }
        //0 Ingles, 1 Español

        StartCoroutine(FraseTexto(this.texto));

    }


    void Update() {
        this.sldProgressBarChargeScene.value += 100;//0.05f;        
    }

    IEnumerator FraseTexto(string frase) {
        int letra = 0;
        this.textScene.text = "";
        
        while(letra < frase.Length) {
            this.textScene.text += frase[letra];
            letra += 1;
            yield return new WaitForSeconds(0.1f);
        }

    }


}

