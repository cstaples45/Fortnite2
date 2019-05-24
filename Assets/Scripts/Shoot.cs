using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform bulletpoint;
    public GameObject bulletPrefab;

    public AudioSource ShootSound;

    private bool fire = true;

    void ShootBullet()
    {
        Instantiate(bulletPrefab, bulletpoint.position, bulletpoint.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetAxis("Fire1") > 0)  && (fire == true))
        {
            ShootBullet();
            ShootSound.Play();
            fire = false;
        }
        if (Input.GetAxis("Fire1") <.5f)
        {
            fire = true;
        }

    }


}

