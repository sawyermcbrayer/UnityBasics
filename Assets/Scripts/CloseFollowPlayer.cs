using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseFollowPlayer : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset = new(0, 5, -1);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
