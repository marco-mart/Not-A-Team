using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheStapler : MonoBehaviour
{
    public Transform firePoint;
    public GameObject staple;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {

            Shoot();

        }
    }

    void Shoot() {

        Instantiate(staple, firePoint.position, firePoint.rotation);
    }
}
