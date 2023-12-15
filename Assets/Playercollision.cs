using UnityEngine;

public class Playercollision : MonoBehaviour
{
    public movement movement;
    public MeshRenderer rend;
    
    //public IsKinematic kinematic;
    /*here collisionInfo is varaible named for collision type , collision type gathers info for colliders*/
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle"){
            movement.enabled = false;
            rend.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        } 
    }
    
    
}
