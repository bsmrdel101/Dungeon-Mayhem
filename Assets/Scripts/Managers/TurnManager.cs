using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class TurnManager : MonoBehaviourPunCallbacks
{
    [Header("Turns")]
    private Player[] _playerList = PhotonNetwork.PlayerList;
    private int currentTurn = 0;


    private void Start()
    {
        // TODO: The current turn should be random

        HandleTurn();
    }

    private void HandleTurn()
    {
        // Display whos turn it is

        // Can end turn

        // Move currentTurn value
    }
}
