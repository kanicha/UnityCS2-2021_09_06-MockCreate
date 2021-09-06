using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMoved : MonoBehaviour
{
    [SerializeField] private GameObject _bar = default(GameObject);

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (_bar.transform.position.x > -2.3f)
            _bar.transform.position += new Vector3(-0.1f, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (_bar.transform.position.x < 2.3f)
            _bar.transform.position += new Vector3(0.1f, 0f, 0f);
        }
    }
}
