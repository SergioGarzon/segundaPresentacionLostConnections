using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class States 
{
    public string _currentEvent;

    public ScoreData scoreData;

    public int _copyLimit = 3;
    public void Iddle()
    {
        Debug.Log(" State");
    }

    public void Die()
    {
        Debug.Log(" State");
    }

    public void Copy()
    {
        switch (_currentEvent)
        {
            case "steal":
                Steal();
                break;
            case "bug":
                Bug();
                break;
            case "shoot":
                Shoot();
                break;
            case "block":
                Block();
                break;
            case "attack":
                Attack();
                break;
            case "fight":
                Fight();
                break;
            case "scanner":
                Scanner();
                break;
            case "light":
                Light();
                break;
            case "invisibility":
                Invisibility();
                break;
            case "doubling":
                Doubling();
                break;
            case "pixel":
                Pixeling();
                break;
            case "electricity":
                Electricity();
                break;
            default:
                Iddle();
                break;
        }

        Debug.Log("Hacker - case2");
        _copyLimit--;
        return;
    }

    public void Steal()
    {
        Debug.Log("Hacker - case3");
        scoreData.shootingPoints = 0;
        _currentEvent = "steal";
    }

    public void Bug()
    {
        _currentEvent = "Bug";
        Debug.Log(" State");
    }

    public void Shoot()
    {
        _currentEvent = "shoot";
        Debug.Log(" State");
    }

    public void Electricity()
    {
        _currentEvent = "electricity";
        Debug.Log(" State");
    }

    public void Block()
    {
        _currentEvent = "block";
        Debug.Log(" State");
    }

    public void Attack()
    {
        _currentEvent = "attack";
        Debug.Log(" State");
    }

    public void Invisibility()
    {
        _currentEvent = "invisibility";
        Debug.Log(" State");
    }

    public void Doubling()
    {
        _currentEvent = "doubling";
        Debug.Log(" State");
    }

    public void Pixeling()
    {
        _currentEvent = "pixeling";
        Debug.Log(" State");
        return;
    }

    public void Scanner()
    {
        _currentEvent = "scanner";
        Debug.Log(" State");
    }

    public void Light()
    {
        _currentEvent = "light";
        Debug.Log(" State");
    }

    public void Fight()
    {
        _currentEvent = "fight";
        Debug.Log(" State");
    }
}
