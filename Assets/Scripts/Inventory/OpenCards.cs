using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class OpenCards : MonoBehaviour
{
    public GameObject inventoryPanel;
    public Button _buttonBack;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(()=>OnButtonInventoryClick());
        _buttonBack.onClick.AddListener((() => OnButtonInventoryBack()));
    }

    void OnButtonInventoryClick(){
        inventoryPanel.SetActive(true);
    }

    void OnButtonInventoryBack()
    {
        inventoryPanel.SetActive(false);
    }

    
    
}
