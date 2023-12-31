using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PlayerListing : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _text;
    public Player Player { get; private set; }

    public void SetPlayerInfo(Player player) {
        Player = player;

        int result = -1;
        if (player.CustomProperties.ContainsKey("RandomNumber"))
            result = (int) player.CustomProperties["RandomNumber"];
        _text.text = result.ToString() + ", " + player.NickName;
    }
}
