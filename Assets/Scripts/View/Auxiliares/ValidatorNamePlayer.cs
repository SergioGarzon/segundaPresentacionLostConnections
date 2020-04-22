using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ValidatorNamePlayer : MonoBehaviour
{
    public Button btnPlayGame;
    public GameObject panelValidator;
    public Text personajeElegido;
    public InputField txtNombreIngresado;
    public Texture texturaIngles;
    public Texture texturaEspanol;
    public RawImage imagenPanel;
    
    void Start()
    {
    }

    public void ValidarNombreIngresado()
    {
        if (this.txtNombreIngresado.text.Equals(""))
        {
            if (!PlayerPrefs.HasKey("LenguajeGuardado"))
            {
                PlayerPrefs.SetInt("LenguajeGuardado", 0); 
            }

            //0 Ingles, 1 Español
            int valor = PlayerPrefs.GetInt("LenguajeGuardado", 0);

            if (valor == 0)
                this.imagenPanel.texture = this.texturaIngles;
            else
                this.imagenPanel.texture = this.texturaEspanol;

            this.panelValidator.SetActive(true);
            return;
        }


        SceneManager.LoadScene("Prototipo2_MundoAbierto");
            
    }

}
