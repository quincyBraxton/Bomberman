using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 10f;
    private float maxX = 2.35f;
    private float minX = -2.35f; 
    // Start is called before the first frame update

    // Update is called once per frame
    void Update(){
        MovePlayer();
    }   

    void MovePlayer(){

        float h = Input.GetAxis("Horizontal");  
        Vector2 currentPosition = transform.position; 

        if (h > 0){
            //going to the right side

            currentPosition.x += speed * Time.deltaTime;

        }
        else if(h < 0){
            //going to the left side

             currentPosition.x -= speed * Time.deltaTime;
              }

            if(currentPosition.x < minX){
                currentPosition.x = minX;
            }
            
            if(currentPosition.x > maxX){
                currentPosition.x = maxX;
            }

        transform.position = currentPosition; 


    }

    void OnTriggerEnter2D(Collider2D target){
        if(target.CompareTag("Bomb")){
            Time.timeScale = 0f;
        }
    }


} //class
