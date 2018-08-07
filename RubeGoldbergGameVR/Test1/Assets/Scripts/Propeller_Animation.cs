using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller_Animation : MonoBehaviour {

    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("Fan_Animation");
    }
}
