using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SensorData.accChange += accelerationChange;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // update inclination of table according to accelerometer data
    void accelerationChange(Vector3 accChange) {
        int multiplier = 20;
        transform.localRotation = Quaternion.Euler(new Vector3(
                accChange.y*multiplier, 0, -1*accChange.x*multiplier));
    }
}
