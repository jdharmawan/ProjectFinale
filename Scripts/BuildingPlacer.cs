using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingPlacer : MonoBehaviour
{
    private bool currentlyPlacing;
    private BuildingPreset curBuildingPreset;

    private float placementIndicatorUpdateRate = 0.05f;
    private float lastUpdateTime;
    private Vector3 curPlacementPos;
    private Vector3 snappedPlacementPos;

    public GameObject placementIndicator;
    public static BuildingPlacer inst;

    public Profile profile;

    void Awake()
    {
        inst = this;
    }

    public void BeginNewBuildingPlacement(BuildingPreset buildingPreset)
    {
        if (profile.gold < buildingPreset.cost)
            return;

        currentlyPlacing = true;
        curBuildingPreset = buildingPreset;
        placementIndicator.SetActive(true);
    }

    public void CancelBuildingPlacement()
    {
        currentlyPlacing = false;
        placementIndicator.SetActive(false);
    }

    void PlaceBuilding()
    {
        GameObject buildingObj = Instantiate(curBuildingPreset.prefab, snappedPlacementPos, Quaternion.identity);
        Farm.inst.OnPlaceBuilding(curBuildingPreset);
        profile.PurchaseBuilding(curBuildingPreset);

        CancelBuildingPlacement();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
            CancelBuildingPlacement();

        if (Time.time - lastUpdateTime > placementIndicatorUpdateRate && currentlyPlacing)
        {
            lastUpdateTime = Time.time;

            curPlacementPos = Selector.inst.GetCurTilePosition();
            snappedPlacementPos = Grid.inst.GetNearestPointOnGrid(curPlacementPos);
            placementIndicator.transform.position = snappedPlacementPos;
        }

        if (currentlyPlacing && Input.GetMouseButtonDown(0))
        {
            PlaceBuilding();
        }
    }
}
