using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

 //Das kompliziertestes Skript. Aber immer noch sehr überschaubar dank SRD!

    //TODO: Wir müssen Zugriff haben, auf das passende bulletPrefab.
    //Das wollen wir im am besten im Editor zuweisen.

    [SerializeField]
    private BulletController bulletPrefab;

    //TODO: Wir brauchen auch eine Referenz auf das Launcher GameObject,
    //damit wir wissen, wo unsere Kugel entstehen soll.

    private Vector3 startPosition;

    private DynamicBullets dynamicBullets;

    [SerializeField]
    private float fireDelay;

    private bool canShoot = true;

	void Start () {
        var launcher = GetComponentInChildren<Launcher>();


        //TODO: startPosition für die Bullet aus dem Launcher holen.

        startPosition = launcher.transform.position;


        //TODO: Beim WeaponLauncher für Events registrieren.
        GetComponentInParent<IWeaponLauncher>().FireWeapons += OnFireWeapon;


        //TODO: Wir brauchen eine Referenz auf DynamicBullets, damit wir dort
        //die neuen Kugeln einhängen können.
        dynamicBullets = FindObjectOfType<DynamicBullets>();

	}
	
    private void OnFireWeapon() {
        //TODO: Bullet instanziieren an der richtigen Position und unter dem
        //richtigen Knoten.

        if(canShoot) {

            Instantiate(bulletPrefab, startPosition, Quaternion.identity, dynamicBullets.transform);
            canShoot = false;
            StartCoroutine(Delay());
        }

    }

    IEnumerator Delay() {
        yield return new WaitForSeconds(fireDelay);
        canShoot = true;
    }

}


