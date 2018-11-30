using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponLauncherInput : MonoBehaviour, IWeaponLauncher {

    private InputManager inputManager;

    public event Action FireWeapons = delegate {};

    //TODO: Beim InputManager subscriben, um zu wissen, wann dieser Befehl befolgt werden soll.
    //TODO: Event Action erstellen, die den Waffen-Abfeuer-Befehl gibt: FireWeapons

    private void Start()
    {
        inputManager = FindObjectOfType<InputManager>();
        inputManager.FireAllWeapons += OnFireWeapons;

    }

    private void OnFireWeapons() {
        FireWeapons();
    }

}
