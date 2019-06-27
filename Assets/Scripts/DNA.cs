using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA 
{
    public List<Vector3> genes = new List<Vector3>();
    public DNA(int genomeLength = 50)
    {
        for (int i = 0; i < genomeLength; i++)
        {
            genes.Add(new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f))); 
        }
    }

    public DNA(DNA parent, float mutationRate = 0.01f)
    {
        for (int i = 0; i < parent.genes.Count; i++)
        {
            float mutationChance = Random.Range(0f, 1f);
            if (mutationChance <= mutationRate)
            {
                genes.Add(new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)));
            }
            else
            {
                genes.Add(parent.genes[i]);
            }
        }
    }
}
