using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [Header("List of cards to buy")] 
    public InventoryItem card1;
    public InventoryItem card2;
    public InventoryItem card3;
    public InventoryItem card4;
    
    [Header("List of the items sold")] 
    [SerializeField]private ShopItem[] shopItems;

    [Header("References")] 
    [SerializeField] private Transform shopContainer;

    [SerializeField]private GameObject shopItemPrefab;

    private InventoryItem _inventoryItem;

    private void Start()
    {
        PopulateShop();
    }

    private void PopulateShop()
    {
        for (int i = 0; i < shopItems.Length; i++)
        {
            ShopItem si = shopItems[i];
            GameObject itemObject = Instantiate(shopItemPrefab, shopContainer);

            itemObject.transform.GetChild(0).GetComponent<Image>().sprite= si.sprite;
            
            itemObject.transform.GetChild(1).GetComponent<Text>().text = si.itemName;
            
            itemObject.GetComponent<Button>().onClick.AddListener(()=>OnButtonClick(si));

        }
    }

    private void OnButtonClick(ShopItem item)
    {
        Debug.Log(item.name);
        if (item.cost <10 & item.cost<=card1.amount)
        {
            card1.amount = card1.amount - item.cost;
            Debug.Log("Sold 1!");
        }
        else if (item.cost < 100 & (item.cost/10)<=card2.amount  & item.cost>=10)
        {
            card2.amount = card2.amount - (item.cost/10);
            Debug.Log("Sold 2!");
        }
        else if (item.cost<1000 & item.cost>=100 & (item.cost/100)<=card3.amount)
        {
            card3.amount = card3.amount - (item.cost/100);
            Debug.Log("Sold 3!");
        }
        else if ((item.cost/1000)<=card4.amount & item.cost>=1000)
        {
            card4.amount = card4.amount - (item.cost/1000);
            Debug.Log("Sold 4!");
        }
        else
        {
            Debug.Log("You dont have that money");
            //activar panel 
        }
        //comparar valor de tarjeta, tipo y el costo del producto
        //true= se agrega la funcionalidad en la batalla con bandera y restar amount
        //false = activar panel de no se puede comprar producto
    } 
}
