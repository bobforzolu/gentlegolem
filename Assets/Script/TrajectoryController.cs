using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrajectoryController : MonoBehaviour
{
    
        public int numPoints = 20;
        public float pointSpacing = 0.1f;

        private LineRenderer lineRenderer;

        private void Start()
        {
            lineRenderer = GetComponent<LineRenderer>();
            lineRenderer.positionCount = numPoints;
        }

        public void TrajectoryLine(GameObject item)
        {
            for (int i = 0; i < numPoints; i++)
            {
            float time = i * pointSpacing;
            Vector2 position = new Vector2(item.transform.position.x, item.transform.position.y) + item.GetComponent<Rigidbody2D>().velocity * time;
            lineRenderer.SetPosition(i, position);
        }
        }
    }


