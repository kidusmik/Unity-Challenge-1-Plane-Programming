using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //rotates 50 degrees per second around z axis
        transform.Rotate(0, 0, 1000 * Time.deltaTime);
    }
}
