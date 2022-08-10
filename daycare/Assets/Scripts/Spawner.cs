using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Homework
{
    /**
     * TODO:
     * 1. Найти примеры полиморфизма в уже написанном коде и в том, что будет написан вами: использовали Abstract, Virtual классы и методы, 
     Override переопределение метода
     * 2. Реализовать удаление объектов из коллекции _spawnedObjects. - можно через _spawnedObjects.Remove(spawnedObject), но у меня выдает ошибку
     * 3. Заменить тип коллекции на более подходящий к данному случаю. Объяснить, если замена не требуется - 
     думаю можно заменить на Queue по принципу первый вошел — первый вышел, или Stack (last in first out), 
     но если стоит задача в произвольном порядке псов выводить, то List подходит
     */
    public class Spawner : MonoBehaviour
    {
        [SerializeField]
        private int _totalAmount;

        [SerializeField]
        private float _spawnDelay;

        [SerializeField]
        private List<GameObject> _objectsToSpawn;

        private readonly List<GameObject> _spawnedObjects = new List<GameObject>();

        void Start()
        {
            StartCoroutine(SpawnNext());
        }

        private IEnumerator SpawnNext()
        {
            var random = new System.Random();
            int i;

            while (true)
            {
                yield return new WaitForSeconds(_spawnDelay);

                if (_spawnedObjects.Count < _totalAmount)
                {
                    i = random.Next(_objectsToSpawn.Count);

                    var spawnedObject = Instantiate(_objectsToSpawn[i], transform);

                    _spawnedObjects.Add(spawnedObject);
                }
            }                
        }
    }
}