using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float yOffset;


    private void OnCollisionEnter(Collision collision)
    {
        player.transform.position = new Vector3(transform.position.x, transform.position.y + yOffset, transform.position.z);
        gameObject.SetActive(false);
    }

}
