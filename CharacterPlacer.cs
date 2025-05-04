using UnityEngine;

public class CharacterPlacer : MonoBehaviour
{
    public GameObject characterPrefab;
    private bool hasPlaced = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !hasPlaced)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit) && hit.collider.tag == "Table")
            {
                Vector3 spawnPos = hit.point + Vector3.up * 0.1f;
                Instantiate(characterPrefab, spawnPos, Quaternion.identity);
                hasPlaced = true;
            }
        }
    }
}
