
using UnityEngine;

public class bulletscript : MonoBehaviour
{
    private float bulletspeedx;
    private float bulletspeedy;
    public Rigidbody2D rb;
    public Rigidbody2D player;
    private float angle;
    private Vector3 mouseposition;
    private Vector3 playerposition;
    private bool fired;
    public Transform bullet;
    public Transform origin;
    public SpriteRenderer bulletsprite;

    private void Start()
    {
        fired = false;
        bulletsprite.enabled = false;
    }


    void FixedUpdate()
    {
        mouseposition = Input.mousePosition;
        playerposition = Camera.main.WorldToScreenPoint(player.position);
        mouseposition.z = -10;
        mouseposition.x = mouseposition.x - playerposition.x;
        mouseposition.y = mouseposition.y - playerposition.y;
        angle = Mathf.Atan2(mouseposition.y, mouseposition.x);
        if (fired == false)
        {
            bullet.position = origin.position;
        }

    }

    private void Update()
    {
        if (fired == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                fired = true;
                bulletsprite.enabled = true;
                bulletspeedx = 5 * Mathf.Cos(angle);
                bulletspeedy = 5 * Mathf.Sin(angle);

            }
        }
        rb.velocity = new Vector2(bulletspeedx, bulletspeedy);

        if (Input.GetMouseButtonDown(0))
        {

        }
    }
}
