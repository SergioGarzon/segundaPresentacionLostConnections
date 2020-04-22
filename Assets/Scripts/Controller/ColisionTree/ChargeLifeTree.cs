using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChargeLifeTree : MonoBehaviour
{
    private int valorColision;

    void Start()
    {
        this.valorColision = 0;
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.valorColision = 1;
        }
    }

    
    void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            this.valorColision = 2;
        }    
    }
    
    public int VeracidadActivadorPanel()
    {
        return this.valorColision;
    }

    public void SetValorColisionActivadorPanel(int valorC)
    {
        this.valorColision = valorC;
    }

}

