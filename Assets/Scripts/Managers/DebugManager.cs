using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class DebugManager : MonoBehaviourPunCallbacks
{
    [Header("Multiplayer")]
    [SerializeField] private bool _autoJoinRoom = false;


    private void Awake()
    {
        if (!_autoJoinRoom || PhotonNetwork.IsConnected) return;
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions{ MaxPlayers = 8, IsVisible = true, IsOpen = true, BroadcastPropsChangeToAll = true }, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        for (int i = 0; i < PhotonNetwork.PlayerList.Length; i++)
        {
            PhotonNetwork.PlayerList[i].NickName = $"Player {i}";
        }
        PhotonNetwork.LoadLevel("Game");
    }
}
