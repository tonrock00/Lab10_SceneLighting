using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunControl : MonoBehaviour
{
    [SerializeField] private float sunRotationDegreePerSecond = 30.0f;

    private Light sun;
    // Start is called before the first frame update
    void Start()
    {
        sun = this.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        sun.transform.Rotate(new Vector3(0, 1, 0), this.sunRotationDegreePerSecond * Time.deltaTime);
    }
}
