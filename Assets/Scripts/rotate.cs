using UnityEngine;

public class rotate : MonoBehaviour
{
   
    public Transform target;
    public float angle;


    void Start()
    {
        
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
      
        angle = Mathf.Atan2(Input.GetAxis("C-Vertical"), Input.GetAxis("C-Horizontal"))*Mathf.Rad2Deg;
        target.rotation = Quaternion.Euler(0, 0, angle);

    }
}
