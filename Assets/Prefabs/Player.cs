using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    bool isGround = false;
    public float jumpForce = 1;
    public KeyCode jumpKey = KeyCode.Space;
    public string groundTag = "Ground";
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(jumpKey)){
            jump();
        }
        
    }

    void jump(){
        if(!isGround) return;
        rb.AddForce(Vector3.up * 1,ForceMode.Impulse);
        isGround = false;
    }
    void OnCollisionEnter(Collision col){
        if(col.transform.CompareTag(groundTag)){
            isGround = true;
        }
    }
}
