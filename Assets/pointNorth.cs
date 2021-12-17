using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointNorth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SensorData.comChange += compassChange;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // update rotation to match compass pointing
    void compassChange(Quaternion toNorth) {
        transform.localRotation = toNorth;
    }
}
