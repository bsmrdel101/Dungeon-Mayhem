using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Pun.UtilityScripts;
using Photon.Realtime;
using TMPro;
using UnityEngine;

public class TurnManager : MonoBehaviourPunCallbacks
{
    [Header("Turns")]
    private Player[] _playerList = PhotonNetwork.PlayerList;
    private int _currentTurn = 0;

    [Header("References")]
    [SerializeField] private TextMeshProUGUI _playerName;
 

    private void Start()
    {
        _currentTurn = Random.Range(0, _playerList.Length - 1);
        HandleTurn();
    }

    private void HandleTurn()
    {
        _playerName.text = _playerList[_currentTurn].NickName;

        // Can end turn

        // Move currentTurn value
    }

    public void OnClick_EndTurn()
    {
        _currentTurn += 1;
        if (_currentTurn > _playerList.Length)
        {
            _currentTurn = 0;
        }
    }
}