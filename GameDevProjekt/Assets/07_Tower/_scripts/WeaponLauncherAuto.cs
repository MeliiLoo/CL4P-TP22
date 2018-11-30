using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponLauncherAuto : MonoBehaviour, IWeaponLauncher {

    public event System.Action FireWeapons = delegate { };

	
	// Update is called once per frame
	void Update () {
        FireWeapons();
	}
}
