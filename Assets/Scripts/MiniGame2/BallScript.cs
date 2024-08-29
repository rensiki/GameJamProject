using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Sprite factoryBall;
    public float StopTimer = 2;

    Rigidbody2D ballRb;
    SpriteRenderer ballSprite;    

    RaycastHit hit;
    Ray ray;

    float MaxDistance = 10f;
    
    void Awake(){
        ballSprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        ray = new Ray();
        ray.origin = transform.position;
        ray.direction = Vector3.down;
        Debug.DrawRay(transform.position, GetComponent<Rigidbody2D>().velocity*-1, Color.red);
    }

    IEnumerator StopBall()
    {   //2초정도 동안 날라가다 정지하고 설치됨
        yield return new WaitForSeconds(StopTimer);
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        yield return new WaitForSeconds(0.1f);
        if (Physics.Raycast(ray.origin, ray.direction, out hit, MaxDistance)){
            Debug.Log("Ball ray");
            if(hit.collider.gameObject.tag == "Area"){
                Debug.Log("Ball ray detected area");
            }
        }
        gameObject.tag = "Ball";
      
        ballSprite.sprite = factoryBall;
    }
    private void OnTriggerStay2D(Collider2D other) {
        if(other.gameObject.tag == "Forest"&&gameObject.tag == "Ball"){
            Debug.Log("Ball is in the area");
            other.gameObject.SetActive(false);
        }
    }

}
