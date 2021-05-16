using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]//tranferir dados para outras classes

public struct Link
{
    public enum direction {UNI, BI}//unilateral e bilateral
    public GameObject node1;
    public GameObject node2;
    public direction dir;
}

public class WPManager : MonoBehaviour
{
    public GameObject[]waypoints;
    public Link[] links;
    public Graph graph = new Graph();

    // Start is called before the first frame update
    void Start()
    {
        if (waypoints.Length > 0)
        {
            foreach(GameObject wp in waypoints)//loop
            {
                graph.AddNode(wp);
            }
            foreach(Link l in links)
            {
                graph.AddEdge(l.node1, l.node2);//caminho certo
                if(l.dir == Link.direction.BI)
                {
                    graph.AddEdge(l.node2, l.node1);//caminho inverso
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        graph.debugDraw();
    }
}
