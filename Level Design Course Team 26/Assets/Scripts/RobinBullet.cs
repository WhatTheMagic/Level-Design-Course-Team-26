using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobinBullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody projectileBody;
    [SerializeField] private GameObject damageIndicatorPrefab;

    public void Initialize()
    {
        projectileBody.AddForce(transform.forward * 2500 + transform.up * 100f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject damageIndicator = Instantiate(damageIndicatorPrefab);
        damageIndicator.transform.position = collision.GetContact(0).point;
        Destroy(this.gameObject);
    }
}
