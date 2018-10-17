using System.Collections;
using UnityEngine;

public class EveSwimming : MonoBehaviour {

    public Animator anim;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space)) {
            anim.SetTrigger("isSwimming");
            anim.ResetTrigger("isNotSwimming");
        } else {
            anim.ResetTrigger("isSwimming");
            anim.SetTrigger("isNotSwimming");
        }
	}
}
