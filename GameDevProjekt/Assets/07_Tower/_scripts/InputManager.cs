using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    public event Action FireAllWeapons = delegate { };

    // TODO: Eine Event Action erstellen namens "FireAllWeapons".
    // TODO: Die Event Action dann aufrufen, solange wir die Leertaste drücken.

    void Update()
    {
        // soll immer Schiessen
        // if (Input.GetKey(KeyCode.Space))
        {
            FireAllWeapons();
        }
    }
}
