using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroungCheker : MonoBehaviour

{
    player _player; 


    void Awake()
    {
        _player = GameObject.Find("Mario_0").GetComponent<player>();
    }

    void OnTriggerStay2D(Collider2D col)
    {
        _player.isGorounded = true;
        _player._animator.SetBool("Jumping", false);
    }

    void OnTriggerExit2D(Collider2D col)

    {
        _player.isGorounded = false;
    }

}
