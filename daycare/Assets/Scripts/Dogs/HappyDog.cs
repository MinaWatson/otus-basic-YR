using Homework.Common;
using Homework.Movement;
using UnityEngine;

namespace Homework.Dogs
{
    
    public class HappyDog : Dog
    {
        public override void Start()
        {
            Move = new Walk(this, -4, 4, 1);
        }
        public override void ChangeColor()
        {
            var random = new System.Random();
            var red = (float)random.NextDouble();
            GetSpriteRenderer().color = new Color(0.5f + red / 2, 0.1f, 0.1f);
        }
    }
}