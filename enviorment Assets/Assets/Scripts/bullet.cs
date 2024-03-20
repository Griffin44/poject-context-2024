using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<Health>(out Health objectHealth))
        {
            objectHealth.TakeDamage(1);
        }
        Destroy(gameObject);
    }
}
