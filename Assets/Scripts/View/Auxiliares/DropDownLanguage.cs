using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropDownLanguage : MonoBehaviour
{
    public Text txtOptionsPanel,_lblLabelLanguage, _txtSound, _lblActivateSound,
        _txtVolumeSound, _txtTextSoundAux, _txtTextVolumeAux, _txtTextActiveSoundAux, txtButtonText;
    private int valor;
    public TMP_Dropdown drpDownLanguage;
    


    public void CambiarValorComboBox()
    {

        valor = drpDownLanguage.value;


        if (this.valor == 0)
            this.TextoIngles();

        if (this.valor == 1)
            this.TextoEspanol();


        PlayerPrefs.SetInt("LenguajeGuardado", valor);
        PlayerPrefs.Save();


    }

    private void TextoEspanol()
    {
        this.txtOptionsPanel.text = "OPCIONES";
        this._lblLabelLanguage.text = "Lenguaje";
        this._txtSound.text = "Sonido";
        this._lblActivateSound.text = "Activar";
        this._txtVolumeSound.text = "Volumen Sonido";
        this._txtTextSoundAux.text = "Sonido Auxiliar";
        this._txtTextVolumeAux.text = "Volumen Auxiliar";
        this._txtTextActiveSoundAux.text = "Activar";
        this.txtButtonText.text = "VOLVER";
    }

    private void TextoIngles()
    {
        this.txtOptionsPanel.text = "OPTIONS";
        this._lblLabelLanguage.text = "Languague";
        this._txtSound.text = "Sound";
        this._lblActivateSound.text = "Activate";
        this._txtVolumeSound.text = "Volume Sound";
        this._txtTextSoundAux.text = "Sound Aux";
        this._txtTextVolumeAux.text = "Volume Aux";
        this._txtTextActiveSoundAux.text = "Activate";
        this.txtButtonText.text = "BACK";
    }




}
