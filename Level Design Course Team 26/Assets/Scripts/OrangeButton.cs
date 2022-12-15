using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeButton : MonoBehaviour
{
    public GameObject platform1;
    public GameObject platform2;
    public GameObject inactivePlatform1;
    public GameObject inactivePlatform2;
    public GameObject button1;
    public GameObject button2;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            platform1.SetActive(true);
            inactivePlatform1.SetActive(false);
            button1.SetActive(false);

            platform2.SetActive(false);
            inactivePlatform2.SetActive(true);
            button2.SetActive(true);
        }
    }
}
