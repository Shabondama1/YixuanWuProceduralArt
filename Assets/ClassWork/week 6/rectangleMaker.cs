using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rectangleMaker : MonoBehaviour
{
    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        Vector3[] positions = new Vector3[4] { new Vector3(-0.5f, 0.9f, 0), new Vector3(-0.5f, -0.9f, 0), new Vector3(0.5f, -0.9f, 0), new Vector3(0.5f, 0.9f, 0)};
        DrawTriangle(positions, 0.02f, 0.02f);
    }

    void DrawTriangle(Vector3[] vertexPositions, float startWidth, float endWidth)
    {
        lineRenderer.startWidth = startWidth;
        lineRenderer.endWidth = endWidth;
        lineRenderer.loop = true;
        lineRenderer.positionCount = 4;
        lineRenderer.SetPositions(vertexPositions);
    }

}