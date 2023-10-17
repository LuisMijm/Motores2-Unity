using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactercontroller : MonoBehaviour
{
    public int maxHealth_;
    public int health_;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth_ = 100;
        health_ = 10;
        Debug.Log("current health: " + health_);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
