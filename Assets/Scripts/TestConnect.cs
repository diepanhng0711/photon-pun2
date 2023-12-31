using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class TestConnect : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {   
        Debug.Log("Connecting to Photon Server...");
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.NickName = MasterManager.GameSettings.NickName;
        PhotonNetwork.GameVersion = MasterManager.GameSettings.GameVersion;
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Connect to the master server
    public override void OnConnectedToMaster() {
        Debug.Log("Connecting to the server");
        Debug.Log(PhotonNetwork.LocalPlayer.NickName);
        if (!PhotonNetwork.InLobby) {
            PhotonNetwork.JoinLobby();
        }
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("Disconnected from the server for the reason " + cause.ToString());
    }
}
