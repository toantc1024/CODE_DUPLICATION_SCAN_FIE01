using UnityEngine;

public class ONode
{
    public GameObject obstacle;
    public ONode next;

    public ONode(GameObject obstacle)
    {
        this.obstacle = obstacle;
    }
}
