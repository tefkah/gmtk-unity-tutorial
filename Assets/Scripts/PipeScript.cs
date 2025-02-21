using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public delegate void OnPlayerPassedPipe();

    public float moveSpeed = 10;
    public float deadZone = -50f;

    public GameObject topPipe;
    public GameObject bottomPipe;

    private void Start() { }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);

        if (transform.position.x < deadZone)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        onPlayerPassedPipe?.Invoke();
    }

    public static event OnPlayerPassedPipe onPlayerPassedPipe;
}
