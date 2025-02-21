using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public delegate void OnHit();

    public Rigidbody2D rb;
    public int jumpHeight = 15;

    private bool dead;

    private int score;

    private void Start()
    {
        dead = false;
        score = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        if (dead)
            return;

        if (Input.GetKeyDown(KeyCode.Space))
            rb.linearVelocity = Vector2.up * jumpHeight;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        dead = true;
        onHit?.Invoke();
    }

    public static event OnHit onHit;
}
