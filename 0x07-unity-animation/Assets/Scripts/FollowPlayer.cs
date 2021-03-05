#pragma warning disable 0649
using System;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform target;

    private void LateUpdate()
    {
        var position = target.position;
        transform.position = new Vector3(position.x, position.y + 0.5f, position.z);
    }
}
