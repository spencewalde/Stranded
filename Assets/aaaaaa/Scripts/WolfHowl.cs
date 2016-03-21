using UnityEngine;
using System.Collections;

public class WolfHowl : MonoBehaviour
{
    private const float MinInterval = 5f;
    private const float MaxInterval = 20f;

    private float nextInterval;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextInterval)
        {
            AudioHandler.Instance.PlaySound(AudioHandler.Instance.WolfHowl);
            nextInterval = Time.time + Random.Range(MinInterval, MaxInterval);
        }
    }
}
