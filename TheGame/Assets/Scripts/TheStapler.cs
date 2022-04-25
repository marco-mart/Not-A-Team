using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheStapler : MonoBehaviour
{
    public Transform firePoint;
    public GameObject staple;
    private float shotCooldown = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && shotCooldown > 0.5f) {

            Shoot();
            shotCooldown = 0;

        }

        shotCooldown += Time.deltaTime;
    }

    void Shoot() {

        Instantiate(staple, firePoint.position, firePoint.rotation);
    }
}
