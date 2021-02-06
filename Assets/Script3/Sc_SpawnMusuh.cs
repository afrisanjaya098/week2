using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_SpawnMusuh : MonoBehaviour
{
    [SerializeField] GameObject musuh;
    [SerializeField] GameObject posisiAwalMusuh;
    int delaySpawn = 200;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delaySpawn--;
        if(delaySpawn == 0)
        {
            delaySpawn = 200;
            Vector3 offset = new Vector3(0f, 1f, 0f);
            Instantiate(musuh, posisiAwalMusuh.transform.position + offset, Quaternion.identity);
        }
    }
}
