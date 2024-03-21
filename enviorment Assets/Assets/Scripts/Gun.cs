using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shootAnchor;
    [SerializeField] private float shootForce = 0;

    public void Shoot() {
        GameObject bullet = Instantiate(bulletPrefab, shootAnchor.position, Quaternion.identity);
        Physics.IgnoreCollision(gameObject.GetComponentInChildren<Collider>(), bullet.GetComponent<Collider>());
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
        bulletRb.AddForce(transform.forward * shootForce, ForceMode.Impulse);
    }
}
