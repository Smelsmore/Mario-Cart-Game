using System.Collections;
using Unity;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class powerUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void onTriggerEnter(Collider other) {
       if (other.CompareTag("Player")) {
         Player player = other.GetComponent<Player>();
         if (player != null) {
           player.ActivateSpeed();
         }

       }

    }
}
