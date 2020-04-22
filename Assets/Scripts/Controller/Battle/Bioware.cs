using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bioware : MonoBehaviour
{

    public int position;

    private States _states;

    public int shootingPoints;

    private ScoreData _scoreData;
    [SerializeField] private KeyCode _shootKey;
    [SerializeField] private KeyCode _fightKey;
    public IEnumerator ChooseBiowareState()
    {
        yield return new WaitUntil((() => Input.anyKey));

        if (_scoreData.shootingPoints == 100 && Input.GetKey(_shootKey))
        {
            ShootOnClick();
        }
        else if (Input.GetKey(_fightKey))
        {
            FightOnClick();
        }
        else
        {
            _states.Iddle();
            Debug.Log("Iddle-Bioware");
        }
    }
    void ShootOnClick()
    {
        _states.Shoot();
        _scoreData.shootingPoints = 0;
        Debug.Log("Bioware - Shooting");

    }

    void FightOnClick()
    {
        _states.Fight();
        Debug.Log("Bioware - Fight");
    }
}
