using UnityEngine;

public class sprite_move : MonoBehaviour
{
    public Rigidbody2D rigid;
    private Vector2 velocity;
    private Vector2 force;
    private Vector2 fall;
    public float fallmultiplier = 2.5f;
    public float lowjumpmultiplier = 2f;
    private bool jump = true;
    public float maxJump = 2f;
    private float jumpCount = 0f;
    public Transform transform;
    public Transform ArmTransform;
    private bool facingRight = false;
    public PolygonCollider2D coll;
    private float JoystickDirection;
    private Vector2 xVelocity;
    public float speed = 750f;

    public float jumpConstant;

    public Animator Anim;


    private Vector2 stop;
    public float stopmultiplier = 100;

    private bool grounded;

    [SerializeField]
    GameObject JumpParticles;


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ground" && Mathf.Abs(rigid.velocity.y) < 1)
        {
            jumpCount = 0;
            jump = true;
            grounded = true;
            speed = 750f;
            Anim.SetInteger("Jumping", 0);
        }

    }


    // Use this for initialization
    void Start()
    {
        force = new Vector2(10f, 0f);
        fall = new Vector2(0f, 400f);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        stop = new Vector2(-rigid.velocity.x*stopmultiplier, 0);

        xVelocity = new Vector2(rigid.velocity.x, 0);

        JoystickDirection = Input.GetAxis("Horizontal") / Mathf.Abs(Input.GetAxis("Horizontal"));

        //Debug.Log(jumpCount);
        velocity = rigid.velocity;


        if(Mathf.Abs(Input.GetAxis("Horizontal")) >0)
        {
            rigid.AddForce(speed * (force - JoystickDirection * xVelocity) * Time.deltaTime * Mathf.Abs(Input.GetAxis("Horizontal"))*Input.GetAxis("Horizontal"));
        }

       


        if (Input.GetAxis("Horizontal") >0 && Anim.GetInteger("Jumping") != 1)
        {
            Anim.SetInteger("Running", 1);
        }

        if(Mathf.Approximately(Input.GetAxis("Horizontal"), 0))
        {
            Anim.SetInteger("Running", 0);
        }

        if (Input.GetAxis("Horizontal") < 0 && Anim.GetInteger("Jumping") != 1)
        {
            Anim.SetInteger("Running", 1);
        }


       


            //To change direction 
        if (Input.GetAxis("Horizontal") > 0 && facingRight == false)
        {
        transform.Rotate(0f, 180f, 0f);
        ArmTransform.Rotate(180f, 0f, 0f);
        facingRight = true;
        }

        if (Input.GetAxis("Horizontal") < 0 && facingRight == true)
        {
            transform.Rotate(0f, 180f, 0f);
            ArmTransform.Rotate(180f, 0f, 0f);
            facingRight = false;

        }


        if (!Input.GetKey(KeyCode.D) && !Mathf.Approximately(rigid.velocity.x, 0) && !Input.GetKey(KeyCode.A) && grounded == true)
        {
            rigid.AddForce(stop*Time.deltaTime);
        }
        if (!Input.GetKey(KeyCode.A) && !Mathf.Approximately(rigid.velocity.x, 0) && !Input.GetKey(KeyCode.D) && grounded == true)
        {
            rigid.AddForce(stop * Time.deltaTime);
        }

        if(!Mathf.Approximately(rigid.velocity.y, 0))
        {
            grounded = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigid.AddForce(-100 * (force + velocity) * Time.deltaTime);

            //To change direction
            if (facingRight == true)
            {
                transform.Rotate(0f, 180f, 0f);
                ArmTransform.Rotate(180f, 0f, 0f);
                facingRight = false;

            }
        }
        if (Input.GetKeyUp(KeyCode.A))
        {

        }

        //We could change the jumping so that height depends on how long you hold the button, or we could leave it as is
        if (jumpCount > (maxJump - 1))
        {
            jump = false;
        }

        if (Input.GetAxis("Jump")>0 && jump == true)
        {
            rigid.AddForce(fall);
            jumpCount = jumpCount + 1;
            Anim.SetInteger("Jumping", 1);
            Instantiate(JumpParticles, transform.position + new Vector3(0, -1, 0), JumpParticles.transform.rotation);
            speed = 200f;
        }
        if(rigid.velocity.y < 0)
        {
            rigid.velocity += Vector2.up * Physics2D.gravity.y * (fallmultiplier - 1) * Time.deltaTime;
        }

        if (Mathf.Approximately(jumpCount, 0))
        {
            grounded = true;
        }

    }
}
