using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
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
        _view.RPC("UpdatePlayerList", RpcTarget.All);
    }

    [PunRPC]
    private void UpdatePlayerList()
    {
        List<Player> playerlist = new List<Player>();
        for (int i = 0; i < PhotonNetwork.PlayerList.Length; i++)
        {
            if (PhotonNetwork.PlayerList[i].UserId != PhotonNetwork.LocalPlayer.UserId){
                playerlist.Add(PhotonNetwork.PlayerList[i]);
            }
        }

        for (int i = 0; i < playerlist.Count; i++)
        {
            GameObject playerObj = Instantiate(_playerPrefab, _playerPositions[i]);
            playerObj.GetComponentInChildren<TextMeshProUGUI>().text = playerlist[i].NickName;
        }
    }
}
