using UnityEngine;
using System.Collections;

public class Buildplace : MonoBehaviour {
    // The Tower that should be built
    public GameObject towerPrefab;

    void OnMouseUpAsButton() {
        // Build Tower above Buildplace
        GameObject towerInstance = (GameObject)Instantiate(towerPrefab);
        towerInstance.transform.position = transform.position + Vector3.up;
    }
}