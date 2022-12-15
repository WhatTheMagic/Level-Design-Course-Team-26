using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobinButtonDoor : MonoBehaviour
{
    public GameObject door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            door.SetActive(false);
        }
    }
}
