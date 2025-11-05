using UnityEngine;
using Unity.Netcode.Components;
public class ClientNetorkTransform : NetworkTransform   
{

    // public override void  OnNetworkSpawn()
    // {
    //     base.OnNetworkSpawn();
    //     CanCommitToTransform = IsOwner;
    // }

    // public override void OnUpdate()
    // {
    //     CanCommitToTransform = IsOwner;
    //     base.OnUpdate();

    //     if(NetworkManager != null)
    //     {
    //         if(NetworkManager.IsConnectedClient || NetworkManager.IsListening)
    //         {
    //             if(CanCommitToTransform)
    //             {
    //                 TryCommitToTransformToServer(transform, NetworkManager.LocalTime.time);
    //             }
    //         }
    //     }
    // }

    protected override bool OnIsServerAuthoritative()
    {
        return false;
    }
}
