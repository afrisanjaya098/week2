using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musuh : MonoBehaviour
{
    bool gerakKanan = false;
    float posAwalX;
    float jarakGerakMusuh = 7f;

    // Start is called before the first frame update
    void Start()
    {
        posAwalX = this.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (gerakKanan == false)
        {
            this.transform.Translate(new Vector3(3f, 0, 0) * Time.deltaTime);
            if (this.transform.position.x > posAwalX + jarakGerakMusuh)
            {
                gerakKanan = true;
            }
        }
        else
        {
            this.transform.Translate(new Vector3(-3f, 0, 0) * Time.deltaTime);
            if (this.transform.position.x < posAwalX - jarakGerakMusuh)
            {
                gerakKanan = false;
            }
        }
    }
}
