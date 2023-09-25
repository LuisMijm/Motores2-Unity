using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    private Elf myElf_;
    private Orc myOrc_;
    // Start is called before the first frame update
    void Start()
    {
        myElf_ = new Elf();
        myOrc_ = new Orc();

        myElf_.attack_ = 23.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
