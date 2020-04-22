using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Player Charlie
 * Unit name: Hacker
 * Damage (año) = 100
 * unit level: 1
 * Max HP: 50
 * Current HP: 20
 * 
 * 
 * Unit name: Electroquinetico
 * Damage (Daño) : 100
 * unite level: 1
 * Max HP: 50
 * Current HP: 20
 * 
 * 
 * Unit name: Virus 1
 * Damage (daño): 20
 * Unit level: 1
 * Max HP: 20
 * Current HP: 0
 * 
 * 
 * Unit name: Virus 1 copy
 * Damage (daño): 20
 * Unit level: 1
 * Max HP: 20
 * Current HP: 1
 * 
 * 
 */

//Clase Unit es de unidad
public class Unit : MonoBehaviour
{

    public string unitName;
    public string damage;
    public int unitLevel;
    public int maxHP;
    public int currentHP;

    public bool TakeDamage(int dmg)
    {
        currentHP -= dmg;
        if (currentHP <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}