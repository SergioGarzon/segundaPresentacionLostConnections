using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class ScoreData : ScriptableObject
{
    [SerializeField] private int initialScore=150;
    //score del nivel, vida
    [SerializeField] private int initialShootingPoints=0;
    //puntos a cargarse para ataques especiales
    [SerializeField] private int initialGamePoints = 0;
    //puntos totales del juego

    [NonSerialized] public int score;
    [NonSerialized] public int mLife;
    [NonSerialized] public int hLife;
    [NonSerialized] public int shootingPoints;
    [NonSerialized] public int gamePoints;

    public void UpdateScore(int multiplier) {
        score += initialScore * multiplier;
    }
    public void UpdatePoints(int multiplier) {
        shootingPoints = initialShootingPoints;
    }
    public void UpdateGamePoints(int multiplier) {
        gamePoints += initialGamePoints * multiplier;
    }

}
[Serializable]
public class SerializableScoreData {
    private int score;
}
[Serializable]
public class SerializableShootingPoints {
    private int shootingPoints;
}
[Serializable]
public class SerializableGamePoints {
    private int gamePoints;
}
public class SerializableMagoLife {
    private int magoLife;
}
public class SerializableHackerLife {
    private int hackerLife;
}

public class GameData : ScriptableObject
{
    [SerializeField] private State currentState;
    [SerializeField] private State enemysDamagePoints;

    [NonSerialized] public State actualState;
    //para cambiar de estado. Guarda el estado actual 
    [NonSerialized] public State enemyDamage;
    //cuenta los virus muertos

    public void SaveState()
    {
        actualState = currentState;
    }
    public void Damage()
    {
        enemyDamage = enemysDamagePoints;
    }
}
