using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateColorParticleSystems : MonoBehaviour
{
    public ParticleSystem particulas;


    public void ActualizarColorParticulas()
    {
        Color c = Color.white;

        var main = this.particulas.main;
        main.startColor = c;

        Debug.Log(c);
        

        this.StartCoroutine(CorrutinaParar());
    }

    IEnumerator CorrutinaParar()
    {
        
        this.particulas.Play();

        yield return new WaitForSeconds(0.2f);

        this.particulas.Stop();
    }
}
