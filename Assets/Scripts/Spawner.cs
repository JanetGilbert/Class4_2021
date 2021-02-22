using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spamObject;
    public int addPerFrame = 5;
    public float maxDist = 100.0f;
    private Renderer[] cachedRenderer;
    public int addAtStart = 99999; // MORE!


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < addAtStart; i++)
        {
            Vector3 randomPos = Random.onUnitSphere * Random.Range(0.0f, maxDist);

            Instantiate(spamObject, randomPos, Quaternion.identity, transform);

        }

        cachedRenderer = GetComponentsInChildren<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {



        MakeTheRainbow();
        MakeTheRainbowCached();
    }

    void MakeTheRainbow()
    {
        Renderer[] renderers = GetComponentsInChildren<Renderer>();

        foreach (Renderer r in renderers)
        {
            r.material.color = Random.ColorHSV();
        }
    }

    void MakeTheRainbowCached()
    {

        foreach (Renderer r in cachedRenderer)
        {
            r.material.color = Random.ColorHSV();
        }
    }
}
