using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSound : MonoBehaviour
{

    public GameObject objetoTree;
    public ActivateTreeEnergy objetoScriptArbol;
    public AudioSource audioActivar;

    void Start()
    {
        this.objetoScriptArbol = this.objetoTree.GetComponent<ActivateTreeEnergy>();
    }

    void Update()
    {
        if (this.objetoScriptArbol.getActivarBarraEnergia() && audioActivar.isPlaying)
        {
            audioActivar.Play(0);
        }            
        else
        {
            audioActivar.Stop();
        }
                    
    }

}
