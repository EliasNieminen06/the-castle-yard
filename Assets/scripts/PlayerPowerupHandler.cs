using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerupHandler : MonoBehaviour
{
    public GameObject player;
    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject;
    }
    //movment speed power up
    private void SpeedTimer()
    {
        player.GetComponent<PlayerMovementHandler>().playerMovementSpeed *= 1.5f;
       
    }
    private void SpeedTimer2()
    {
        player.GetComponent<PlayerMovementHandler>().playerMovementSpeed /= 1.5f;
    }

   //Fire rate power up
    private void FireRateUp()
    {
        player.GetComponent<PlayerShootingHandler>().fireRate /= 2;
    }

    private void FireRateUp2()
    {
        player.GetComponent<PlayerShootingHandler>().fireRate *= 2;
    }
    
   //What they do
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PUSpeed")
        {
            sound.Play();
            SpeedTimer();
            Invoke("SpeedTimer2", 7f);
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "PUFireRate")
        {
            sound.Play();
            FireRateUp();
            Invoke("FireRateUp2", 10f);
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "PUHealth")
        {
            player.GetComponent<PlayerDataHandler>().PlayerHealTaken(3);
            Destroy(other.gameObject);
        }

    }
}
