using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

[Serializable]
public class CSharpbasic2 : MonoBehaviour
{
    public bool boolValue;
    public int x;
    public int y;
    public int[] array;
    
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
    x = int.MaxValue;
    checked
    {
        try 
        {
            y = x + 1;
            Debug.Log(y);
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
        int intValue = 0; 
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
    [Serializable]
    public struct Structures // Объявить структуру, которая будет содержать все элементы для предыдущих заданий.
    {
    public int x;
    public int y;
    public bool boolValue;
    }
    public void WriteToFile() // Записать в файл как в 1 занятии
    {
    string s1 = Convert.ToString("X " + x);
    string s2 = Convert.ToString("Y " + y);
    string s3 = Convert.ToString("Bool " + boolValue);
    string[] structure = new string[] { s1, s2, s3};
    string contents = string.Join("; ", structure);
    string path = Application.dataPath + "/Structure.txt";
    if (!File.Exists(path)) 
    {
        File.WriteAllText(path, contents);
    }
    }
    private void Start()
    {
        WriteToFile();    
    }  
}
