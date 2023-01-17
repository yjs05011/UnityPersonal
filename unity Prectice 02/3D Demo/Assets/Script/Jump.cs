using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody jumpRigid2;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody jumptreeRigidbody = gameObject.GetComponent<Rigidbody>();
        jumptreeRigidbody.AddForce(0,10,0,ForceMode.Impulse);

        bool isJumpRigid2Null = jumpRigid2 == null || jumpRigid2 == default;
        Debug.Log($"[jump] Is jump rigid2 is null?");

        jumpRigid2.AddForce(0,20, 0, ForceMode.Impulse);
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
