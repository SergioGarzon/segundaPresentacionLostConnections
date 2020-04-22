using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class RandomState
{
    public static int StateE;
    public static int StateLimits;

    public static void RandomStateMethod()
    {
        StateE = Random.Range(1,StateLimits);
        return;
    }
}
