using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class spawnerdecano : MonoBehaviour
{
    public GameObject cano;
    public float spawnrate = 2;
    public float timer = 0;
    public float heightOffset = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer = 0;

        }

    }

    void spawnpipe()
    {
        float lowestpoint = transform.position.y - heightOffset;
        float highestpoint = transform.position.y + heightOffset;

        Instantiate(cano, new Vector3(transform.position.x, Random.Range(lowestpoint,highestpoint), 0), transform.rotation);

    }
}
