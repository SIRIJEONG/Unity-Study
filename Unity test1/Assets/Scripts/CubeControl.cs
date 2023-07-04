using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    private Vector3 cubeRotation = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("�̰� ����Ƽ�� Hello world��!");

    }

    // Update is called once per frame
    void Update()
    {
        cubeRotation.y = (rotationSpeed * Time.deltaTime);
        transform.Rotate(cubeRotation);
    }
}
