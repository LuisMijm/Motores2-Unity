using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody RB_;
    private GameObject PlayerRef_;
    private int damage_;

    // Start is called before the first frame update
    void OnEnable()
    {
        RB_ = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init(GameObject playerref, int damage, Vector3 forcedirection)
    {
        PlayerRef_ = playerref;
        RB_.AddForce(forcedirection, ForceMode.Impulse);
        damage_ = damage;
    }

    public void OnCollisionEnter(Collision collision)
    {
        GameObject goTarget = collision.collider.gameObject;
        IDamageable damageable = goTarget.GetComponent<IDamageable>();
        if(damageable != null)
        {
            damageable.TakeDamage(PlayerRef_, damage_);
        }

        Destroy(gameObject, 0.1f);
    }
}
