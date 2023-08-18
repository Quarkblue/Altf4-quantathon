using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Thirdweb;
using System.Threading.Tasks;

public class PlayMenuScript : MonoBehaviour
{

    public Prefab_ConnectWallet prefab_ConnectWallet;

    // Start is called before the first frame update
    void Start()
    {
        prefab_ConnectWallet = GameObject.Find("Prefab_ConnectWallet").GetComponent<Prefab_ConnectWallet>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        Debug.Log("Play Game");
    }

    public void Profile()
    {
        Debug.Log("Profile");
    }

}
