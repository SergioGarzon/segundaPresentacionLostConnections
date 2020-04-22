using UnityEngine;
[CreateAssetMenu (menuName = "Shop/InventoryItem")]
public class InventoryItem : ScriptableObject
{
    public string itemName;
    public Sprite sprite;
    public int value;
    public Color backgroundColor;
    public int amount;
    public CardType cardType;
    private int _finalValue1;
    private int _finalValue2;
    private int _finalValue3;
    private int _finalValue4;
    private int _gameMoney;

    public void CalculateCardsValue()
    {

        if (value == 1)
        {
             _finalValue1 = value * amount;
        }

        if (value == 10)
        {
             _finalValue2 = value * amount;
        }

        if (value == 100)
        { 
            _finalValue3 = value * amount;
        }

        if (value == 1000)
        {
            _finalValue4 = value * amount;
        }

        _gameMoney = _finalValue1 + _finalValue2 + _finalValue3 + _finalValue4;
    }

}
public enum CardType{HISTORY, INFO, BLACK, ID}