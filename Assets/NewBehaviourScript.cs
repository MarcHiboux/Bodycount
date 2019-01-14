using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    private float crabHealth;
    private float allyCount;

    void Update() {

        if (crabHealth >= 100f)
        {
            GoApeShit();
        }

        if (allyCount >= 5f)
        {
            GTFO();
        }

    }

    void GoApeShit()
    {    }
    void GTFO()
    {    }
    
}

