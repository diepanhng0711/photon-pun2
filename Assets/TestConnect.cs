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
        print("Connecting to the server");
        PhotonNetwork.GameVersion = "0.0.0";
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Connect to the master server
    public override void OnConnectedToMaster() {
        print("Connecting to the server");
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        print("Disconnected from the server for the reason " + cause.ToString());
    }
}
