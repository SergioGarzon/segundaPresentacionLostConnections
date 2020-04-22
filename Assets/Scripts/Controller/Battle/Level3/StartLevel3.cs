using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartLevel3 : MonoBehaviour
{
    public GameObject level3;

    private  bool startLevel=false;

    private BattleMachine3 battleScript;

    public Text dialogText;
    // Start is called before the first frame update
    void Start()
    {
        battleScript = level3.GetComponent<BattleMachine3>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player")&&Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("estás en el nivel 3 we");
            battleScript.enabled = true;
        }
        else
        {
            battleScript.enabled = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Ya no estás en el nivel 3 we");
            battleScript.enabled = false;
            dialogText.text = "Virus Destroyer";
        }
        
    }
}