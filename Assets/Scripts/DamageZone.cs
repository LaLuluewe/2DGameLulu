using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other) {
        RubyControl control = other.GetComponent <RubyControl>();
        if (control != null){
            control.ChangeHealth(-1);
        }
        
    }
}