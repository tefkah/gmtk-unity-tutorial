using UnityEngine;
using UnityEngine.Serialization;

public class PipeSpawnerScript : MonoBehaviour
{
    public PipeScript pipe;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [FormerlySerializedAs("spawnRate")] public float spawnDelaySeconds = 2;

    public float heightOffset;
    public float pipeSeparationIncrease = 0.1f;
    public float maxPipeSeparation = 5.0f;


    private float pipeSeparation;

    private float timer;

    private void Start()
    {
        timer = 0;
        pipeSeparation = 0;
        SpawnPipe();
    }

    // Update is called once per frame
    private void Update()
    {
        if (timer < spawnDelaySeconds)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;

            if (pipeSeparation >= maxPipeSeparation) return;
            pipeSeparation += pipeSeparationIncrease;
        }
    }

    private void SpawnPipe()
        // spawn
    {
        var lowestPoint = transform.position.y - heightOffset;
        var highestPoint = transform.position.y + heightOffset;

        var newPipe = Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0),
            transform.rotation);

        var topPipePosition = newPipe.topPipe.transform.position;
        var bottomPipePosition = newPipe.bottomPipe.transform.position;

        newPipe.topPipe.transform.position = new Vector3(topPipePosition.x, topPipePosition.y - pipeSeparation,
            topPipePosition.z);
        newPipe.bottomPipe.transform.position = new Vector3(bottomPipePosition.x, bottomPipePosition.y + pipeSeparation,
            bottomPipePosition.z);
    }
}