using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Sprite factoryBall;
    public float StopTimer = 2;

    Rigidbody2D ballRb;
    SpriteRenderer ballSprite;    

    void Awake(){
        ballSprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        
    }

    IEnumerator StopBall()
    {   //2초정도 동안 날라가다 정지하고 설치됨
        yield return new WaitForSeconds(StopTimer);
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        yield return new WaitForSeconds(0.1f);
        gameObject.tag = "Ball";
        ballSprite.sprite = factoryBall;
        //돈 감소

    }
    private void OnTriggerStay2D(Collider2D other) {
        if(other.gameObject.tag == "Forest"&&gameObject.tag == "Ball"){
            Debug.Log("Ball is in the Forest");
            other.gameObject.SetActive(false);
            //점수 깍기
        }
        if(other.gameObject.tag == "Area"&&gameObject.tag == "Ball"){
            Debug.Log("Ball is in the Area");
            other.gameObject.SetActive(false);
            //돈 올리기
        }
    }

}
