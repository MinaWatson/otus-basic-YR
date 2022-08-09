using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Player mPlayer = null;
    void Start()
    {
        Load();
    }

    private bool Load()
    {
        if(PlayerPrefs.HasKey("PlayerData"))
        {
            string playerData = PlayerPrefs.GetString("PlayerData");
            Debug.Log($"Load : {playerData}");
            mPlayer = JsonConvert.DeserializeObject<Player>(playerData);
        }
        {
            mPlayer = new Player()
            {name = "MyPlayer", id = 10007};
            string playerData = JsonConvert.SerializeObject(mPlayer);
            Debug.Log($"Save : {playerData}");
            PlayerPrefs.SetString("PlayerData", playerData);
            PlayerPrefs.Save();
        }
        return true;
    }
}
