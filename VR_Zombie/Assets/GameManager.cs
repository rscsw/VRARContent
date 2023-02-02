using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject zombie;

    void Start()
    {
        InvokeRepeating("CreateZombie", 1.0f, 2.0f);
    }

    void CreateZombie()
    {
        Vector3 positionValue = new Vector3(Random.Range(-8f, 8f), 0.5f, Random.Range(28f, 18f));
        GameObject temp = Instantiate(zombie, positionValue, transform.rotation);
    }

    void Update()
    {
        
    }
}
