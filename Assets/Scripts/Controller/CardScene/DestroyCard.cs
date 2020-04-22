using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyCard : MonoBehaviour
{
    [SerializeField] [Range(1, 4)]public int valorTarjeta; //Este es un valor que se asigna al crear la tarjeta
    public GameObject panel;
    public Texture texturaEspanol;
    public Texture texturaIngles;
    public RawImage imagen;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (this.VerificarLenguaje() == 0)
            {
                this.imagen.texture = this.texturaIngles;
            }
            else
            {
                this.imagen.texture = this.texturaEspanol;
            }

                this.gameObject.SetActive(true);
                panel.SetActive(true);
                Destroy(this.gameObject);


                if (this.valorTarjeta == 2)
                    PlayerPrefs.SetInt("ValorGuardadoTarjeta", valorTarjeta);

                
            }

               

    }

        private int VerificarLenguaje()
        {
            int valor = 0;

            if (PlayerPrefs.HasKey("LenguajeGuardado"))
                valor = PlayerPrefs.GetInt("LenguajeGuardado", 0);

            return valor;
        }



}
