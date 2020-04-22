using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseShop : MonoBehaviour
{
    public GameObject shopPanel;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Button>().onClick.AddListener(()=>OnButtonShopBack());
    }

    void OnButtonShopBack()
    { 
        shopPanel.SetActive(false);
    }
}
