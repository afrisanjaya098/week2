using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_CCTV2 : MonoBehaviour
{
    GameObject target;
    float rotate  = 90f;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("hero");
        this.transform.rotation = Quaternion.AngleAxis(45, Vector3.up);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 jarakCCTVtoHero = target.transform.position - this.transform.position;
        float angle = Mathf.Atan2(jarakCCTVtoHero.x, jarakCCTVtoHero.z) * Mathf.Rad2Deg;
        Quaternion rotasi = Quaternion.AngleAxis(angle, Vector3.up);
        //this.transform.rotation = rotasi;
        if(angle> rotate || angle<-rotate)
        //if(angle< - rotate)
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, rotasi, Time.deltaTime);
        //Debug.Log(angle);
    }
}
