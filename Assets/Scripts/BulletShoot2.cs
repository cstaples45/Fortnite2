using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot2 : MonoBehaviour
{
    private float bulletspeedx;
    private float bulletspeedy;
    public Rigidbody2D rb;
    public Transform target;
    private float angle;
    private Vector3 mouseposition;
    private Vector3 playerposition;
    public float speed = 20f;
    public GameObject bullet1;


    // Start is called before the first frame update
    void Start()
    {
        angle = Mathf.Atan2(Input.GetAxis("C-Vertical Controller 2"), Input.GetAxis("C-Horizontal Controller 2"));

        bulletspeedx = speed * Mathf.Cos(angle);
        bulletspeedy = speed * Mathf.Sin(angle);

        rb.velocity = new Vector2(bulletspeedx, bulletspeedy);
    }

    void FixedUpdate()
    {
        if (Mathf.Abs(rb.velocity.magnitude) < 1000)
        {
            Destroy(bullet1);
        }
    }

}
