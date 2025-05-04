using UnityEngine;

public class CharacterInteraction : MonoBehaviour
{
    private bool isDragging = false;

    void OnMouseDown()
    {
        isDragging = true;
    }

    void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if (isDragging)
        {
            float rotX = Input.GetAxis("Mouse X") * 5f;
            transform.Rotate(Vector3.up, -rotX);
        }
    }
}
