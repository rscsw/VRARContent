using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = 20f;
    float lifeTime = 3f;
    private Rigidbody rb;
    public GameObject hitPaticlePrefab;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(this.gameObject, lifeTime);
    }

    void Update()
    {
        rb.AddForce(transform.forward * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("zomBear"))
        {
            other.SendMessage("OnHitBullet");
            Destroy(gameObject);

            /*GameObject temp = Instantiate(hitPaticlePrefab, transform.position, transform.rotation);
            Destroy(temp, 1.0f);*/
        }
    }
}
