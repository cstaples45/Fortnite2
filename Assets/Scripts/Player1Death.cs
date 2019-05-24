
using UnityEngine;

public class Player1Death : MonoBehaviour
{
    public Transform Player1;
    public PlayerCollisionHandler CollisionHandle;
    public Animator Anim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BlastZone")
        {
            CollisionHandle.UpdatePlayer2();
            Anim.SetInteger("Reset", 1);
        }

    }
}
