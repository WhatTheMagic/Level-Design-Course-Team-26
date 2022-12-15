using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobinButtonDoor : MonoBehaviour
{
    public GameObject button;
    public GameObject door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            button.SetActive(false);
            door.SetActive(false);
        }
    }
}
