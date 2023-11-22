using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed_ = 5.0f;
    public float lateralSpeed_ = 5.0f;
    public GameObject shootPrefab_;
    public Transform TR_;
    public int ID_ = 0;
    public float ballForce_ = 200.0f;
    public int ballDamage_ = 100;


    // Start is called before the first frame update
    void Start()
    {
        TR_ = GetComponent<Transform>();
    }

    public void TakeDamage(GameObject causer, int dmg)
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject go = Instantiate(shootPrefab_, TR_.position, TR_.rotation);
            BallController bc = go.GetComponent<BallController>();
            if(bc != null)
            {
                bc.Init(gameObject, ballDamage_, TR_.forward * ballForce_);

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
