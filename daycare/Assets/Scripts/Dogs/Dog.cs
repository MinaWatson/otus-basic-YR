using Homework.Common;
using Homework.Movement;
using UnityEngine;

namespace Homework.Dogs
{
    /**
     * TODO:
     * 1. Добавить всем собакам способность гавкать: достаточно метода, пишущего в Unity-консоль строку с сообщение. +
     * 2. HappyDog должен гавкать более радостно - HappyDog гавкает, а грустный дог ходит по кругу.
     * 3. (сложно) Пусть собаки гавкают только тогда, когда меняют направление движения. + реализовано в классе Walk +
     + дополнительно код для разворота объекта transform.localRotation
     */
    public abstract class Dog : MonoBehaviour, IColorChangeable
    {
        public abstract void ChangeColor();
        protected Move Move;
        private SpriteRenderer _spriteRenderer;

        public SpriteRenderer GetSpriteRenderer()
        {
            if (_spriteRenderer == null)
                _spriteRenderer = GetComponentInChildren<SpriteRenderer>();

            return _spriteRenderer;
        }
        public void Awake()
        {
            InputController.Instance.OnColorChanged += OnColorChanged;
        }
        public virtual void Start()
        {
            InputController.Instance.OnColorChanged += OnColorChanged;
        }
        protected void Update()
        {
            Move.Execute();
        }

        private void OnDestroy()
        {
            InputController.Instance.OnColorChanged -= OnColorChanged;
        }

        private void OnColorChanged()
        {
            ChangeColor();
        }
    }
}