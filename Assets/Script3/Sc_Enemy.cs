using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_Enemy : MonoBehaviour
{
    GameObject movepoint;
    List<GameObject> listPoint = new List<GameObject>();
    float speedMove = 5f;

    private void Awake()
    {
        movepoint = GameObject.Find("movepoint");

        foreach(Transform child in movepoint.transform)
        {
            listPoint.Add(child.gameObject);
        }

        foreach(GameObject x in listPoint)
        {
           // Debug.Log("list: " + x.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (listPoint.Count > 0)
        {
            Vector3 targetPos = new Vector3(listPoint[0].transform.position.x, this.transform.position.y, listPoint[0].transform.position.z);
            this.transform.position = Vector3.MoveTowards(this.transform.position, targetPos, speedMove * Time.deltaTime);

            Vector3 posPoint = targetPos - this.transform.position;
            this.transform.rotation = Quaternion.LookRotation(posPoint);

            Vector3 posMusuh = this.transform.position;
            posMusuh.y = listPoint[0].transform.position.y;
            if (Vector3.Distance(listPoint[0].transform.position, posMusuh) < 0.1f)
            {
                listPoint.RemoveAt(0);
            }
        }
        else
        {
            Debug.Log("musuh sampai tujuan");
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "peluru")
        {
            Destroy(this.gameObject);
            Debug.Log("hancur");
        }
    }
}
