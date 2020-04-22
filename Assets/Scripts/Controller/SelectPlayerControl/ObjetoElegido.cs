using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetoElegido : MonoBehaviour
{
    public Text valorElegidoText;

    void Start()
    {
        PlayerPrefs.SetInt("ObjetoElegido", 0);
    }

    void Update()
    {

        int x = PlayerPrefs.GetInt("ObjetoElegido", 0);


        if (x == 0)
            this.valorElegidoText.text = "ATIF";
        else
            this.valorElegidoText.text = "CHARLIE";

    }
}
