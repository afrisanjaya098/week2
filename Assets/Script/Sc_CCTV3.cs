using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_CCTV3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion target = Quaternion.Euler(0, 100, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, 1f * Time.deltaTime);
    }
}
