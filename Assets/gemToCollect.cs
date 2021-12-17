using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gemToCollect : MonoBehaviour
{
    public delegate void gemCollected();
    public static event gemCollected gemCollect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ball collided with gem
    void OnTriggerEnter(Collider other) {
        Debug.Log("Collected Gem");
        gemCollect();
        Destroy(this.gameObject);
    }
}
