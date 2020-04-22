using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambiarColorTexto : MonoBehaviour
{

    public Text txtButton;

    void Start()
    {
    }

    public void CambiarElColorTexto()
    {
        this.txtButton.color = Color.red;
    }

    public void volverColorActual()
    {
        this.txtButton.color = Color.white;
    }

}
