using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public delegate void OnHit();

    public Rigidbody2D rb;
    public int jumpHeight = 15;

    private bool isDead;

    private void Start()
    {
        isDead = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (isDead)
            return;

        if (
            Input.GetKeyDown(KeyCode.Space)
            || Input.GetMouseButtonDown(0)
            || Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began
        )
            rb.linearVelocity = Vector2.up * jumpHeight;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        onHit?.Invoke();
    }

    public static event OnHit onHit;
}
