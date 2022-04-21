using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiles : MonoBehaviour
{

    private float min_X = -1.03f;
    private float max_X = 1.03f;
    private float updatezPosition = 0f;


    void Update()
    {
        SpawnPlateform();
    }
    void SpawnPlateform()
    {
        GameObject plateform = ObjectPooling.instance.GetPlateform();
        float randomValue = Random.Range(min_X, max_X);
        float newPos = 0 + updatezPosition;
        if (plateform != null)
        {
            plateform.transform.position = new Vector3(randomValue, 0f, newPos);
            plateform.SetActive(true);
            updatezPosition += 0.8f;
        }
    }
}
