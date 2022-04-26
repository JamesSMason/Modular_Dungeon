using UnityEngine;

public class Windmill : MonoBehaviour
{
    [SerializeField] Transform windmillSails = null;
    [SerializeField] float rotationSpeed = 1.0f;

    void Update()
    {
        windmillSails.Rotate(new Vector3(0, 0, rotationSpeed * Time.deltaTime));
    }
}