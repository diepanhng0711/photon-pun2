using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class RoomListing : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _text;
    
    public RoomInfo RoomInfo 
    {
        get;
        private set;
    }

    public void SetRoomInfo(RoomInfo roomInfo) {
        RoomInfo = roomInfo;
        _text.text = roomInfo.MaxPlayers + ", " + roomInfo.Name;
    }

    public void OnClick_Butoon() {
        PhotonNetwork.JoinRoom(RoomInfo.Name);
    }
}
