using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_Camera : MonoBehaviour
{
    GameObject hero;
    // Start is called before the first frame update
    void Start()
    {
        hero = GameObject.Find("hero");
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 0f;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 50;
        }
        if (Input.GetKey(KeyCode.RightShift))
        {
            speed = -50;
        }
        this.transform.LookAt(hero.transform);
        this.transform.RotateAround(hero.transform.position, Vector3.up, speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Z))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.X))
        {
            this.transform.Translate(Vector3.back * Time.deltaTime, Space.Self);
        }
    }
}
