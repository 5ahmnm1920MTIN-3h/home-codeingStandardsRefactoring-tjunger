using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    [SerializeField] float jumpForce;
    private bool grounded;
    private bool gameOver = false;
    private string triggerJump = "Jump";
    private string debugDeleteMe = "DeleteMe";
    private string groundTag = "Ground";
    private string obstacleTag = "Obstacle";
    private string deathAnim = "SantaDeath";

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && !gameOver && !gameOver && !gameOver)
        {
            if (grounded == true)
            {
                jump();
            }
        }
    }

    void jump()
    {
        grounded = false;

        rb.velocity = Vector2.up * jumpForce;

        anim.SetTrigger(triggerJump);

        GameManager.instance.IncrementScore();
        Debug.Log(debugDeleteMe);
    }

    private bool SetGameOverTrue()
    {
        return true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == groundTag)
        {
            grounded = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == obstacleTag)
        {
            GameManager.instance.GameOver();
            Destroy(collision.gameObject);
            anim.Play(deathAnim);
            gameOver = SetGameOverTrue();
        }
    }
}
