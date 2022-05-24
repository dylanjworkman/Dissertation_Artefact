using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectPoints : MonoBehaviour
{

    void OnTriggerEnter(Collider other){
        ScoreManager.theScore += 1;
        Destroy(gameObject);
        Debug.Log("Score Added!");
    }
}
