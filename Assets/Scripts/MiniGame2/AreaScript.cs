using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaScript : MonoBehaviour
{
        private void OnTriggerStay2D(Collider2D other) {
        if(other.gameObject.tag == "Ball"){
            Debug.Log("Ball is in the area");
            
        }
    }


}
