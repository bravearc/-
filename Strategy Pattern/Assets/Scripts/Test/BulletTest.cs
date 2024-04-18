using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTest : MonoBehaviour
{
    private Collider2D e_bullet;
    private Rigidbody2D bulletrb;

    // Start is called before the first frame update
    void Start()
    {
        e_bullet = GetComponent<Collider2D>();
        bulletrb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(e_bullet);

    }
}
