using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    public GameObject plateformPrefab;
    
    public static ObjectPooling instance;
    public int amountOfPlateform = 20;
   
    public List<GameObject> storePlateform = new List<GameObject>();
    

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        for (int i = 0; i < amountOfPlateform; i++)
        {
            GameObject plateformObj = Instantiate(plateformPrefab);
            plateformObj.SetActive(false);
            storePlateform.Add(plateformObj);
        }
        
    }

    public GameObject GetPlateform()
    {
        for (int i = 0; i < storePlateform.Count; i++)
        {
            if (!storePlateform[i].activeInHierarchy)
            {
                return storePlateform[i];
            }
        }
        return null;
    }
  
}
