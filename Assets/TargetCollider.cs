using Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCollider : MonoBehaviour
{
    [SerializeField]private Collider2D collider_;

    private void Start()
    {
        collider_ = GetComponentInChildren<Collider2D>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine("WaitForPlayer");

            Debug.Log("player is in");
        }
    }

    private void Bullseye() {
       
    }

    IEnumerator WaitForPlayer()
    {
        yield return new WaitForSeconds(2f);
        Bullseye();
    }
}
