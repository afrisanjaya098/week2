using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_HeroSc2 : MonoBehaviour
{
    List<GameObject> targetList = new List<GameObject>();
    GameObject target;
    int noList = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Vector3 targetpos = target.transform.position - this.transform.position;
            this.transform.rotation = Quaternion.LookRotation(targetpos);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            noList++;
            if(noList>= targetList.Count)
            {
                noList = 0;
            }
            pindahTarget();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "musuh")
        {
            targetList.Add(other.gameObject);
            pindahTarget();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "musuh")
        {
            targetList.Remove(other.gameObject);
            pindahTarget();
        }
    }

    private void pindahTarget()
    {
        if (targetList.Count > 0)
        {
            target = targetList[noList];
        }
        foreach(var item in targetList)
        {
            Debug.Log(item.ToString());
        }
    }
}
