using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class CSharpbasic2 : MonoBehaviour
{
    public bool boolValue;
    public int[] array;
    public int a;
    public int b;
    public int intValue;
    
    [Serializable]
    public struct Structures // Объявить структуру, которая будет содержать все элементы для предыдущих заданий.
    {
        public int a;
        public int b;
        public bool boolValue;
        public int[] array;
        public int intValue;
    }
    [ContextMenu("CheckArray")] 
    private void CheckArray()
    {
        boolValue = true; // Создать переменную булл, 
        if(boolValue) // если true, создается массив
        {
            array = new int[8];
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = (int)Mathf.Pow((i-1), 2); // вывести массив, чтобы каждый элемент был квадратом предыдущего     
                Debug.Log(array[i]);
            }     
        }
        else
        {
            return;
        }
    }
    [ContextMenu("CheckException")] 
    private void CheckException() // исключение ( переполнение значения)
    {
    a = int.MaxValue;
    checked
    {
        try 
        {
            b = a + 1;
            Debug.Log(b);
        }
        catch
        {
            Debug.Log("Max value reached");
        }
        finally
        {
            Debug.Log("Finally");
        }
    }
    }
    [ContextMenu ("CheckRef")] 
    private void CheckRef() // на вход передать переменную REF
    {
        intValue = 0; 
        Ref(ref intValue); 
        Debug.Log("REF:" + intValue);
    }
    [ContextMenu ("CheckRefOut")]
    private void CheckRefOut() // на вход передать переменную OUT
    {
        int intValue;
        RefOut(out intValue); 
        Debug.Log("OUT: " + intValue);
    }
    private void Ref(ref int intValue) 
    {
        intValue++;
    }
    private void RefOut(out int intValue) 
    {
        intValue = 100;
        intValue--;
    }  
}
