using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugGuiHandler : MonoBehaviour
{
    public Canvas canvas;
    private GameObject player;
    public GameObject gamemanager;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    public void IncreaseSpeed()
    {
        player.GetComponent<PlayerMovementHandler>().playerMovementSpeed++;
    }
    public void DecreaseSpeed()
    {
        player.GetComponent<PlayerMovementHandler>().playerMovementSpeed--;
    }
    public void IncreaseHealth()
    {
        player.GetComponent<PlayerDataHandler>().PlayerHealTaken(1);
    }
    public void DecreaseHealth()
    {
        player.GetComponent<PlayerDataHandler>().PlayerDamageTaken(1);
    }
    public void IncreaseWaveCount()
    {
        gamemanager.GetComponent<GameManager>().vaweDifficulty++;
    }
    public void DecreaseWaveCount()
    {
        gamemanager.GetComponent<GameManager>().vaweDifficulty--;
    }
    public void IncreaseKillCount()
    {
        player.GetComponent<PlayerDataHandler>().playerKills++;
    }
    public void DecreaseKillCount()
    {
        player.GetComponent<PlayerDataHandler>().playerKills--;
    }
}
