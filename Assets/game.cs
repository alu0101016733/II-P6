using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game : MonoBehaviour
{
    int numGems_ = 0;

    GameObject hexgon_;
    GameObject softStar_;

    int point = 0;
    Text pointsText_;
    
    // Start is called before the first frame update
    void Start()
    {
        gemToCollect.gemCollect += gemTrigger;
        hexgon_ = GameObject.Find("Hexgon");
        softStar_ = GameObject.Find("SoftStar");
        pointsText_ = GameObject.Find("pointCount").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
       if (numGems_ < 1) {
           spawnGem();
           numGems_ += 1;
       } 
    }

    // Spawn new gem ad random location in game table
    void spawnGem() {
        float randX = Random.Range(-4.35f, 4.21f);
        float randZ = Random.Range(-2.56f, 2.7f);
        Vector3 position = new Vector3(randX,.25f,randZ);
        Quaternion quat = new Quaternion(0,0,0,0);
        int whatGem = Random.Range(0,2);
        if(whatGem == 0) {
            Instantiate(hexgon_, position, quat, transform);
        } else {
            Instantiate(softStar_, position, quat, transform);
        }
    }

    // increase points if gem was collected
    void gemTrigger() {
        numGems_ -= 1;
        pointsText_.text = "Points: " + ++point;
    }
}
