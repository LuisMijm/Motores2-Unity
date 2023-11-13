using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed_ = 5.0f;
    public float lateralSpeed_ = 5.0f;
    public float interactDistance_ = 5.0f;
    GameObject interactable;
    RaycastHit hitinfo_;


    void Update()
    {
        if (Physics.Raycast(this.transform.position, Vector3.forward, out hitinfo_, interactDistance_))
        {
            if (Input.GetKey(KeyCode.E))
            {
                interactable = hitinfo_.transform.parent.gameObject;
                //interactable
            }
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * speed_ * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * lateralSpeed_ * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * speed_ * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * lateralSpeed_ * Time.deltaTime);
        }
    }
}
