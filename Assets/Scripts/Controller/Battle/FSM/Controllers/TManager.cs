using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TManager : MonoBehaviour
{
    public int turn=0;

    public int turnLimit=2;//cantidad de personajes en pantalla

    public static TManager tmanager;
    // Start is called before the first frame update
    void Start()
    {
        tmanager = this.GetComponent<TManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (turn < turnLimit)
        {
            turn = 1;
        }
    }//cuando es 1 es el turno de los players y cuando suma 1 es el turno de los enemigos
}
