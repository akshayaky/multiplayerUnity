using UnityEngine;
using Unity.Netcode; 
public class ConnectionButtons : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Join()
    {
        NetworkManager.Singleton.StartClient();
    }

    public void Host()
    {
        NetworkManager.Singleton.StartHost();
    }
}
