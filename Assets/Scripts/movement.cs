using UnityEngine;

public class movement : MonoBehaviour {

    [Range(0, 10)]
    public float speed;
    [Range(0, 20)]
    public float JumpPower;

    public Rigidbody2D rb;
    public Transform groundCheck;
    public LayerMask WhichLayerIsGround;

    [Range(0, 10)]
    public int ExtraJumps;
    int extraJumps;

    float moveInput;

    bool isGrounded = false;

	void Start () 
    {
        extraJumps = ExtraJumps;
        rb = GetComponent<Rigidbody2D>();

	}

    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        isGrounded = Physics2D.OverlapBox(groundCheck.position, new Vector2(0.1f, 0.1f), 0, WhichLayerIsGround);

    }

	void Update()
	{
        if (isGrounded)
        {
            extraJumps = ExtraJumps;
        }

        if (extraJumps > 0 && Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = Vector2.up * JumpPower;
            extraJumps--;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && isGrounded)
        {
            rb.velocity = Vector2.up * JumpPower;
        }
	}
}
