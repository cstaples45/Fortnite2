using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public Transform bulletPrefab;

    private void Start()
    {
        //GameObject player = GameObject.FindWithTag("Player1");
        //Physics2D.IgnoreCollision(bulletPrefab.GetComponent<Collider2D>(), player.GetComponent<Collider2D>());
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground" || collision.gameObject.tag == "BlastZone")
            Destroy(this.gameObject);
    }
}
