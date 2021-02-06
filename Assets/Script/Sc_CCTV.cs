using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_CCTV : MonoBehaviour
{
  GameObject target;
    float rotateKanan = 90f;
    float rotateKiri = 270f;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("hero");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 jarakCCTVtoHero = target.transform.position - this.transform.position;
        Quaternion rot = Quaternion.LookRotation(jarakCCTVtoHero);
        //this.transform.rotation = Quaternion.Euler(0, rot.eulerAngles.y, 0);
        // if (this.transform.rotation.y <= 90 && this.transform.rotation.y>=-90)
        //{
        if (rotateKanan != 0 || rotateKiri !=0)
        {
            if(rot.eulerAngles.y < rotateKanan || rot.eulerAngles.y > rotateKiri)
                this.transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, rot.eulerAngles.y, 0), 50f * Time.deltaTime);
        }
            
        //}
        
        //Debug.DrawRay(target.transform.position, jarakCCTVtoHero,Color.red);
        //Debug.Log("ini rot: "+ rot.eulerAngles.y);
        //Debug.Log("ini sphere: " + this.transform.rotation);
    }

}
