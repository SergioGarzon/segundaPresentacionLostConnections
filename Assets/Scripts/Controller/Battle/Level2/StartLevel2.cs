using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartLevel2 : MonoBehaviour
{
    public GameObject level2;

    private bool startLevel=false;

   private BattleMachine2 battleScript;

    public Text dialogText;
    // Start is called before the first frame update
    void Start()
    {
        battleScript = level2.GetComponent<BattleMachine2>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player")&&Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("estás en el nive2 ");
            battleScript.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Ya no estás en el nivel 2 ");
            battleScript.enabled = false;
            dialogText.text = "Virus Destroyer";
        }
        
    }
}