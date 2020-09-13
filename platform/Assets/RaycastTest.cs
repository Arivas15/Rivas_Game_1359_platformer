using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Ray r = new Ray(transform.position, Vector3.down);

        Debug.DrawLine(r.origin, r.origin + (Vector3.down * 2));

        RaycastHit hit;
        if(Physics.Raycast(r, out hit, 2))
        {
            if(hit.transform != null)
            {
                Debug.Log(hit.transform.name);

                if(hit.transform.GetComponent<FloorInfo>() != null)
                {
                    Debug.Log(hit.transform.GetComponent<FloorInfo>().value);
                }
                else
                {
                    Debug.Log("Has no Floor Value");
                }
            }
        }*/
    }
}
