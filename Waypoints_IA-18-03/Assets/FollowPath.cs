using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    //Transform goal;
    //float speed = 5.0f;
    //float accuracy = 1.0f;//identificar o ponto e fazer o contorno para nao bugar
    //float rotSpeed = 2.0f;//velocidade de rotação para nao bugar

    public GameObject wpManager;
    GameObject[] wps;
    UnityEngine.AI.NavMeshAgent agent;//usado para NavMesh

    //Waypoints
    //GameObject currentNode;
    //int currentWP = 0;
    //Graph g;

    // Start is called before the first frame update
    void Start()
    {
        wps = wpManager.GetComponent<WPManager>().waypoints;
        agent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();//atribuindo Navmesh

        //Waypoints
        //g = wpManager.GetComponent<WPManager>().graph;
        //currentNode = wps[0];
    }

    public void GoToHeli()
    {
        agent.SetDestination(wps[0].transform.position);//setando destino para Heliponto com NavMesh

        //Waypoints
        //g.AStar(currentNode, wps[0]);
        //currentWP = 0;
    }

    public void GoToRuin()
    {
        agent.SetDestination(wps[6].transform.position);//setando destino para Ruinas com NavMesh

        //Waypoints
        //g.AStar(currentNode, wps[6]);
        //currentWP = 0;
    }

    public void GoToTanks()
    {
        agent.SetDestination(wps[4].transform.position);//setando destino para outro ponto com NavMesh

        //Waypoints
        //g.AStar(currentNode, wps[4]);
        //currentWP = 0;
    }

    // Update is called once per frame
    void LateUpdate()
    {

        /* Código utilizado para Waypoints
        if (g.getPathLength() == 0 || currentWP == g.getPathLength())
            return;

        //O nó que estará mais proximo neste momento
        currentNode = g.getPathPoint(currentWP);

        //Se estivermos mais proximo bastante do nó o player se moverá para o proximo
        if(Vector3.Distance(g.getPathPoint(currentWP).transform.position, transform.position) < accuracy)
        {
            currentWP++;
        }

        if (currentWP < g.getPathLength())
        {
            goal = g.getPathPoint(currentWP).transform;
            Vector3 lookAtGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z);//vai seguir o proximo ponto
            Vector3 direction = lookAtGoal - this.transform.position;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, //rotaçao com suavidade
                Quaternion.LookRotation(direction), 
                Time.deltaTime * rotSpeed);
        }*/
    }
}
