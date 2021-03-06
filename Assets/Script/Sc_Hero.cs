﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_Hero : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.rotation = Quaternion.Euler(new Vector3(0, 30, 0));
        Debug.Log("Rotasi Y Hero: " + this.transform.eulerAngles.y);
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        this.transform.Translate(new Vector3(0, 0, v) * Time.deltaTime * 3f);
        this.transform.Rotate(new Vector3(0, h, 0) * 5f);
    }
}
