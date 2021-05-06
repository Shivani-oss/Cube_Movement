using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
   

    void OnCollisionEnter(Collision collisionInfo)
    {
       

        //Debug.Log(collisionInfo.collider.name);
        if(collisionInfo.collider.tag == "Obstacle")
        {
            //Debug.Log("We hit an Obstacle");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

            FindObjectOfType<AudioManager>().Play("PlayerCollide");

        }
    }
}
