using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float spawnRate;
    private float timer = 0;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Instantiate(pipe, transform.position, transform.rotation);
            timer = 0;
        }
    }
}