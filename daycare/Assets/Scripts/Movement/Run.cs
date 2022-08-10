using UnityEngine;

namespace Homework.Movement
{
    /**
     * TODO:
     * 1. Реализовать этот тип перемещения по аналогии с Walk, но отличающийся от него,
     * например, пусть перемещение будет по окружности заданного радиуса. +
     * 2. Заменить передвижение у HappyDog и/или SadDog этим типом. Убедиться, что он работает. +
     */
    public class Run : Move
    {
 
    private float _speed = 0.5f;
    private float _radius = 0.002f;
    private Vector2 _centre;
    private float _angle;
    public Run(MonoBehaviour owner) : base(owner)
    {
    }
    public Run(MonoBehaviour owner, float angle, float radius, float speed) : base(owner)
    {
        _angle = angle;
        _radius = radius;
        _speed = speed;
    }
    public override void Execute()
     {
 
         _centre = Owner.transform.position;
         _angle += _speed * Time.deltaTime;
 
         var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * _radius;
         Owner.transform.position = _centre + offset;
     }
    }
}