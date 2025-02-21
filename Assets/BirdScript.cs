using UnityEngine;
using UnityEngine.Serialization;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public int jumpHeight = 15;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector2.up * jumpHeight;
        }
    }
}
