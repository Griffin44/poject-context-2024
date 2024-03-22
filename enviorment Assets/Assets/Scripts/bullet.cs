using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Vector3 lastPos;

    private void Start()
    {
        lastPos = transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("collided with: " + collision.gameObject.name);
        if (collision.gameObject.TryGetComponent<Health>(out Health objectHealth))
        {
            print("object has health");
            objectHealth.TakeDamage(1);
        }
        Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        CheckPassthrough();
    }

    private void CheckPassthrough() { 
        float distance = (lastPos - transform.position).magnitude;
        Vector3 direction = (lastPos - transform.position).normalized;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, direction, out hit, distance)) {
            print("raycast hit: " + hit.transform.gameObject.name);
            if (hit.transform.gameObject.TryGetComponent<Health>(out Health healthObject))
            {
                print("object has health");
                healthObject.TakeDamage(1);
            }
            Destroy(gameObject);
        }
        lastPos = transform.position;
    }
}
