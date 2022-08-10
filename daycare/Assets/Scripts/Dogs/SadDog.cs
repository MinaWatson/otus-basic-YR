using Homework.Common;
using Homework.Movement;
using UnityEngine;

namespace Homework.Dogs
{
    /**
     * TODO:
     * 1. Реализовать этот тип по аналогии с HappyDog.+
     * 2. Грустная собака должна перекрашиваться в оттенки синего. +
     * 3. (сложно) Перенести метод GetSpriteRenderer в более подходящее место. + перенесла в Dog
     */
    public class SadDog : Dog
    {
        public override void Start()
        {
            Move = new Run(this, 0f, 0.002f, 0.5f);
        }
        public override void ChangeColor()
        {
            var random = new System.Random();
            var blue = (float)random.NextDouble();
            GetSpriteRenderer().color = new Color(0.1f, 0.1f, 0.5f + blue / 2);
        }
    }
}