using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    Animator fire_Animator;
    GameObject fire;
    GameObject[] fires;

    void Awake()
    {
        fires = GameObject.FindGameObjectsWithTag("Fires");
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        foreach (GameObject fire in fires)
        {
            fire_Animator = fire.GetComponent<Animator>();
            fire_Animator.SetBool("isOnFire", true);
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        foreach (GameObject fire in fires)
        {
            fire_Animator = fire.GetComponent<Animator>();
            fire_Animator.SetBool("isOnFire", false);
        }
    }
}
