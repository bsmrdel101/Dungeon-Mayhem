using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class GameManager : MonoBehaviourPunCallbacks
{
    [Header("Table")]
    [SerializeField] private Transform[] _playerPositions;

    [Header("References")]
    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private PhotonView _view;


    private void Start()
    {
        UpdatePlayerList();
    }

    private void UpdatePlayerList()
    {
        for (int i = 0; i < PhotonNetwork.PlayerList.Length; i++)
        {
            if (PhotonNetwork.PlayerList[i].NickName != PhotonNetwork.LocalPlayer.NickName)
            {
                Instantiate(_playerPrefab, _playerPositions[i]);
            }
        }
    }
}
