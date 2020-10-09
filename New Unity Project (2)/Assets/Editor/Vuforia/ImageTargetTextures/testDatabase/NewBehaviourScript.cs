using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    GameObject cube; 
    // Start is called before the first frame update
    void Start()
    {
        cube=GameObject.Find("myCube");
    }

    // Update is called once per frame
    void Update()
    {
        cube.transform.position+=new Vector3(0,- (float)0.001 ,0);
    }
}
