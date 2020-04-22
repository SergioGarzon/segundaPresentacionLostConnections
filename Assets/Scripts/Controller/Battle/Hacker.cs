using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;
using UnityEngine.UI;

public class Hacker : MonoBehaviour
{
    private States _states = new States();

    public ScoreData scoreData;

    public int copyLimit = 3;

    public int _damage;

    public static Hacker Instance;

    [SerializeField] private KeyCode bugKey, copyKey, stealKey;

    [SerializeField] private KeyCode _electricityKey, _pixelKey, _LightingKey;

    private void Awake()
    {
        Instance = this;
    }



    /*
     * VER COMO INDEXAR ESTOS METODOS
     * 
    public void setAttackHacker(int valor)
    {
        this.ataqueHacker = valor;
    }

    public void setVirusAttack(int valorVirus)
    {
        this.valorVirus = valorVirus;
    }

    /*
    private string textoInglesEspanol(string texto)
    {
        int valor = PlayerPrefs.GetInt("LenguajeGuardado", 0);

        string textoDevolver = texto;

        if (valor == 0)
        {
            //0 es en Ingles
            textoDevolver = "";
        }
        else
        {
            //1 en Español
            textoDevolver = "";
        }

        return "";
    }
    */

}
