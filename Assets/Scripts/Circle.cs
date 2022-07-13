using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Circle : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0, 100)]
    public int segments = 70;
    [Range(0, 7)]
    public float xradius = 1;
    [Range(0, 7)]
    public float yradius = 1;
    LineRenderer line;

    [System.Obsolete]
    void Start()
    {
        line = gameObject.GetComponent<LineRenderer>();

        line.SetVertexCount(segments + 1);
        line.SetWidth(.005f, .005f);
        line.useWorldSpace = false;
        CreatePoints();
    }

    void CreatePoints()
    {
        float x;
        float y;

        float angle = 00f;

        for (int i = 0; i < (segments + 1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle) * xradius;
            y = Mathf.Cos(Mathf.Deg2Rad * angle) * yradius;

            line.SetPosition(i, new Vector3(x, 0, y));

            angle += (360f / segments);
        }
    }
}