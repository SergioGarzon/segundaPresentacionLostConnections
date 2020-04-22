using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartLevel1 : MonoBehaviour
{
    public GameObject level1;

    private bool startLevel = false;

    private BattleMachine battleScript;

    public Text dialogText;
    // Start is called before the first frame update
    void Start()
    {
        battleScript = level1.GetComponent<BattleMachine>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("estás en el nivel 1");
            battleScript.enabled = true;
        }
        else
        {
            battleScript.enabled = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("abandonaste la batalla");
            battleScript.enabled = false;
            dialogText.text = "Virus Destroyer";
        }
    }
}
