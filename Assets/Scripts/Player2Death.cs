using UnityEngine;
using System.Collections;

public class Player2Death : MonoBehaviour
{
    public Transform Player2;
    public PlayerCollisionHandler CollisionHandle;
    public Animator Anim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BlastZone")
        {
            CollisionHandle.UpdatePlayer1();
            Anim.SetInteger("Reset", 1);
        }
    }
}
