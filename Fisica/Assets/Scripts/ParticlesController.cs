using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ParticlesController : MonoBehaviour
{
    [Header("Properties")]
    [SerializeField] int systemParticlesNumber;
    [SerializeField] int systemInitialSpeed;
    [SerializeField] int systemInitialAngle;
    [SerializeField] float systemLifeTime;
    [SerializeField] float systemGravity;

    [SerializeField] GameObject particlePrefab;
    List<GameObject> particles = new();

    void Update()
    {
        for (int i = particles.Count - 1; i >= 0; i--)
        {
            Particle p = particles[i].GetComponent<Particle>();

            UpdateParticlePosition(p, Time.deltaTime);

            if (p.activeTime > p.maxLifeTime)
            {
                Destroy(particles[i]);
                particles.RemoveAt(i);
            }
        }
    }

    void CreateParticleExplotion()
    {
        for (int i = 0; i < systemParticlesNumber; i++)
        {
            GameObject obj = Instantiate(particlePrefab, transform.position, Quaternion.identity);

            Particle p = obj.GetComponent<Particle>();

            p.initialSpeed = Random.Range(systemInitialSpeed * 0.8f, systemInitialSpeed * 1.2f);
            p.initialAngle = systemInitialAngle + Random.Range(-10f, 10f);
            p.maxLifeTime = Random.Range(systemLifeTime * 0.8f, systemLifeTime * 1.2f);
            p.gravity = systemGravity;

            p.activeTime = 0;
            p.startPosition = transform.position;

            particles.Add(obj);
        }
    }

    void UpdateParticlePosition(Particle p, float time)
    {
        p.activeTime += time;

        float angleRad = p.initialAngle * Mathf.Deg2Rad;

        float x = p.initialSpeed * Mathf.Cos(angleRad) * p.activeTime;
        float y = p.initialSpeed * Mathf.Sin(angleRad) * p.activeTime - 0.5f * p.gravity * Mathf.Pow(p.activeTime, 2);

        p.transform.position = p.startPosition + new Vector3(x, y, 0);
    }

    public void OnPress(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            CreateParticleExplotion();
        }
    }
}