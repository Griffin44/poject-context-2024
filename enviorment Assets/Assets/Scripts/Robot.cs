using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    [SerializeField] private GameObject player;

    void Update()
    {
        Vector3 lookDirection = player.transform.position - transform.position;
        transform.rotation = Quaternion.LookRotation(lookDirection);
    }
}
