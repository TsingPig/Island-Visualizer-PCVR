using Mirror;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(NetworkManager))]
public class AutoStartServer : MonoBehaviour
{
    NetworkManager manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = GetComponent<NetworkManager>();
        manager.StartHost();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
