using UnityEngine;
using extOSC;

public class OSCSpawnControl : MonoBehaviour
{
    public OSCReceiver receiver;
    public string oscAddress = "/spawnrate";

    public static float spawnInterval = 3f;

    void Start()
    {
        receiver.Bind(oscAddress, OnSpawnIntervalReceived);
    }

    void OnSpawnIntervalReceived(OSCMessage message)
    {
        if (message.ToFloat(out float interval))
        {
            spawnInterval = Mathf.Clamp(interval, 0.1f, 10f);
            Debug.Log("Intervalle de spawn mis à jour via OSC : " + spawnInterval);
        }
    }
}
