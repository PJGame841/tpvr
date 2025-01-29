using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnHit : MonoBehaviour
{
    public GameObject brakeVersion;
    public float bForce = 1.0f;
    protected Rigidbody rb;
    private int active = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (rb.velocity.magnitude > bForce && active == 0)
        {
            active = 1;
            Instantiate(brakeVersion, transform.position, transform.rotation);
            rb.AddExplosionForce(10f, Vector3.zero, 0f);
            Destroy(gameObject);
        }
    }
}
