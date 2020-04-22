using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{

    //Creo un vector de GameObject
    public GameObject[] characterList; 
    private int index;
    private int activarCharlieAtif;



    private void Start()
    {
        //transform.childCount es cuando no se la cantidad de elementos del vector
        this.characterList = new GameObject[transform.childCount];


        //Fill the array with out model
        //Recorrer el transform.childCount es igual a vector.length pero en C#
        for (int i = 0; i < transform.childCount; i++)
        {
            //Esto es asignar al vector[posicion] = transform.get(i).toString()
            characterList[i] = transform.GetChild(i).gameObject;
        }

        //We toggle of their renderer
        foreach (GameObject go in characterList)
        {
            go.SetActive(false);
        }

        //We toggle on the first index
        if (characterList[0])
        {
            characterList[0].SetActive(true);
        }

        this.activarCharlieAtif = 0;
       
    }


    public void ToggleLeft()
    {
        if(this.activarCharlieAtif == 1)
        {
            characterList[index].SetActive(false);

            index--;

            if (index < 0)
            {
                index = characterList.Length - 1;
            }

            characterList[index].SetActive(true);

            GuardarPlayerPref(0);

            this.activarCharlieAtif = 0;
        }


    }

    public void ToggleRight()
    {

        if(this.activarCharlieAtif == 0)
        {
            characterList[index].SetActive(false);

            index++;

            if (index == characterList.Length)
            {
                index = characterList.Length - 1;
            }

            characterList[index].SetActive(true);

            GuardarPlayerPref(1);

            this.activarCharlieAtif = 1;
        }
        
    }


    private void GuardarPlayerPref(int valor)
    {
        PlayerPrefs.SetInt("ObjetoElegido", valor);
        PlayerPrefs.Save();
    }



}
