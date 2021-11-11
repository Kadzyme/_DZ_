using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private Camera fpsCam;
    [SerializeField] private string nameOfKiller;
    [SerializeField] private Weapon weapon;

    private void Start()
    {
        weapon = gameObject.transform.GetComponent<Weapon>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, weapon.range))
        {
            Health target = hit.transform.GetComponent<Health>();
            if(target != null)
            {
                target.TakeDamage(weapon.damage, nameOfKiller);
            }
        }
    }
}
