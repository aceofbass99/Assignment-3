using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform player;	// A variable that stores a reference to our Player
	public float offset;		// A variable that allows us to offset the position (x, y, z)
	
	// Update is called once per frame
	void Update () {
        // Set our position to the players position and offset it
        var pos = player.position;
        pos.z += offset;
        pos.x /= 2;
        pos.y += 12.5f;
        pos.y /= 2;
        transform.position = pos;
	}
}
