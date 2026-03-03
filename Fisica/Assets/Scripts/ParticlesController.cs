using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesController : MonoBehaviour
{
    [Header("Properties")]
    [SerializeField] int systemParticlesNumber;
    [SerializeField] int systemInitialSpeed;
    [SerializeField] int systemInitialAngle;
    [SerializeField] float systemLifeTime;
    [SerializeField] float systemGravity;

    [SerializeField] GameObject Particle;
    List<GameObject> particles = new();

    private void Start()
    {
        
    }

    void CreateParticleExplotion()
    {

    }

    void UpdateParticlePosition(Particle p, float time)
    {

    }
}
