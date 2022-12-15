using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobinBullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody projectileBody;
    [SerializeField] private GameObject damageIndicatorPrefab;

    public void Initialize(Vector3 direction)
    {
        projectileBody.AddForce(direction * 700f + transform.up * 300f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}
