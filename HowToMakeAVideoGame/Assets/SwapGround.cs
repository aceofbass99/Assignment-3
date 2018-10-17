using UnityEngine;

public class Teleport : MonoBehaviour {
    public PlayerMovement movement;
    // Use this for initialization
    void OnCollisionEnter(Collision collisionInfo) {
        if (Input.GetKey("space")) {
            Debug.Log("pressed");
            if (collisionInfo.collider.name == "Ground")
            {
                Debug.Log("Move right");
                movement.moveRight();
            }
            else if (collisionInfo.collider.name == "Ground (1)") {
                Debug.Log("move left");
                movement.moveLeft();
            }
        }
    }
}
