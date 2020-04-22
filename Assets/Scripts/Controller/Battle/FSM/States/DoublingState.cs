using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoublingState : State
{
    public override void InitState() {
        Cloning.Doble();
    }

    public override void UpdateState(float delta) {
        
    }

    public override void ExitState() {
        
    }
}
public class Cloning : MonoBehaviour
{
    public static void Doble()
    {

        GameObject prefab = GameObject.FindObjectOfType<GameObject>();
        for (int i = 0; i<3; i++)
        {
            Instantiate(prefab, new Vector3(i * 2.0f, i * 2.0f, 0), Quaternion.identity); 
            new WaitForSecondsRealtime(5);
        }

        new WaitForSecondsRealtime(5);
    }

}