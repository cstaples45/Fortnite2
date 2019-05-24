
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    private float bulletspeedx;
    private float bulletspeedy;
    public Rigidbody2D rb;
    public Transform target;
    private float angle;
    private Vector3 mouseposition;
    private Vector3 playerposition;
    public float speed = 20f;
    public GameObject bullet;


    // Start is called before the first frame update
    void Start()
    {
        angle = Mathf.Atan2(Input.GetAxis("C-Vertical"), Input.GetAxis("C-Horizontal"));

        bulletspeedx = speed * Mathf.Cos(angle);
        bulletspeedy = speed * Mathf.Sin(angle);

        rb.velocity = new Vector2(bulletspeedx, bulletspeedy);
    }

    void FixedUpdate()
    {
        if(Mathf.Abs(rb.velocity.magnitude) < 19)
        {
            Destroy(bullet);
        }
    }


}
