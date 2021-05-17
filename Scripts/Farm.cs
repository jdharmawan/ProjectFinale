using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Farm : MonoBehaviour
{
    //public int gold;

    private List<BuildingPreset> buildings = new List<BuildingPreset>();

    public static Farm inst;

    void Awake()
    {
        inst = this;
    }

    void Start()
    {
        UnityEditor.AI.NavMeshBuilder.BuildNavMesh();
    }

    public void OnPlaceBuilding (BuildingPreset building)
    {
        buildings.Add(building);
        //gold -= building.cost;
    }

}
