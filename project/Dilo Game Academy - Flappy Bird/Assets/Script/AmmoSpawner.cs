using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoSpawner : MonoBehaviour
{
    [SerializeField]
    private Ammo ammoRef;
    public void SpawnAmmo()
    {
        //Pengecekan Null Variable
        Debug.Log("spwn ammo");
        //menduplikasi Groundref
        Ammo newAmmo = Instantiate(ammoRef, transform.position, Quaternion.Euler(1.25f, 0, -90));

        //mengaktifkan game object
        newAmmo.gameObject.SetActive(true);
    }
}
