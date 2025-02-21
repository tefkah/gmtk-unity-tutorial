using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed = 10;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((Vector3.left * Time.deltaTime * moveSpeed));
    }
}