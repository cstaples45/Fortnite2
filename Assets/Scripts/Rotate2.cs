using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate2 : MonoBehaviour
{

    public Transform target;
    public float angle = 10f;
    private Vector3 mouseposition;
    private Vector3 playerposition;
    public SpriteRenderer sprite;



    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*mouseposition = Input.mousePosition;
        playerposition = Camera.main.WorldToScreenPoint(target.position);
        mouseposition.z = -10;
        mouseposition.x = mouseposition.x - playerposition.x;
        mouseposition.y = mouseposition.y - playerposition.y;
        angle = Mathf.Atan2(mouseposition.y, mouseposition.x) * Mathf.Rad2Deg;
        target.rotation = Quaternion.Euler(0, 0, angle);

        //Debug.Log(angle);*/

        angle = Mathf.Atan2(Input.GetAxis("C-Vertical Controller 2"), Input.GetAxis("C-Horizontal Controller 2")) * Mathf.Rad2Deg;
        target.rotation = Quaternion.Euler(0, 0, angle);


        //Debug.Log(Input.GetAxis("C-Vertical Controller 2"));

        if (Mathf.Abs(angle) < 90)
        {

        }
    }
}
