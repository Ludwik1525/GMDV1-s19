using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour {

    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;

    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab);
        Transform bTransform = bullet.transform;

        bTransform.position = bulletSpawnPoint.position;
        bTransform.forward = transform.up;

        
    }
}
