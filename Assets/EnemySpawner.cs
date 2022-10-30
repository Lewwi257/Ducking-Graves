using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using Random = UnityEngine.Random;

namespace Enemies
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject toSpawnAlly;
        [SerializeField] private GameObject toSpawnFoe;


        [SerializeField] private Transform target;
        [SerializeField] private UnityEngine.Light lightSource;

        [SerializeField] private float maxSpawnDistance;
        [SerializeField] private float spawnTimeDelay;

        [SerializeField][Range(1, 100)] private int maxMobs;
        private int _mobCounter;

        private Vector3 GeneratePosition()
        {
            var lightRange = lightSource.range + 1.5f;

            var targetPosition = target.position;

            var xTarget = targetPosition.x;
            var yTarget = targetPosition.y;

            // var angle = Mathf.PI * 2f / Random.Range(0f, 360f);
            var angle = Random.Range(0f, 359f) * Mathf.PI / 180;
            var cos = Mathf.Cos(angle);
            var sin = Mathf.Sin(angle);

            var x = Random.Range(xTarget, xTarget + cos * (maxSpawnDistance + 1.5f - lightRange)) + cos * lightRange;
            var y = Random.Range(yTarget, yTarget + sin * (maxSpawnDistance + 1.5f - lightRange)) + sin * lightRange;

            return new Vector3(
                x, // wqaaaaaaaaaaa                 ccccccccccccccccccccccccccccccccccccccccccccccccccccccccccxccccccccccccccccccccccccccccccccccccccccdfx, // clamp edge of map
                y,
                -1
            );
        }

        public void Spawn()
        {
            if (_mobCounter >= maxMobs)
            {
                return;
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Instantiate(Random.value > 0.5 ? toSpawnAlly : toSpawnFoe, GeneratePosition(), Quaternion.identity).GetComponent<Mob>();
            // .SetType(Random.value > 0.5 ? Mob.EnemyType.Foe : Mob.EnemyType.Ally);
            // go;
            ++_mobCounter;
        }

        public void DeleteMob()
        {
            --_mobCounter;
        }

        void Start()
        {
            InvokeRepeating(nameof(Spawn), 0, spawnTimeDelay);
        }
    }
}
