using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fppcameracontroller : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform mountTransform;
    [SerializeField] float rotationSpeed = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = mountTransform.position;

        float rotationInput = Input.GetAxis("Horizontal");

        if(Mathf.Abs(rotationInput) > 0.1f)
        {
            transform.Rotate(Vector3.up, rotationInput * rotationSpeed * Time.deltaTime);
        }
    }
}
