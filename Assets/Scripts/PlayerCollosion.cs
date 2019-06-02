using UnityEngine;

public class PlayerCollosion : MonoBehaviour
{
    public PlayerMovement movement;

    // OnCollisionEnter is called whenever object 
    // collides with another rigid body
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            
        }
    }
}
