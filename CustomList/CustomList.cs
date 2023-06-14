using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //Member Variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;

        //Constructor
        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
            count = 0;
        }
        public int Count { get => count;}
        public int Capacity { get => capacity;}

        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }


        //Member Methods (CAN DO)
        public void Add(T item)
        {
            //'item' parameter should be added to internal 'items' array
            //if items array is at capacity, double capacity and create new array
            //transfer all items to new array
            try
            {
                if (Count < Capacity)
                {
                    items[count] = item;
                    ++count;
                }
                else if (Count >= Capacity)
                {
                    capacity *= 2;
                    T[] array = new T[Capacity];
                    for (int i = 0; i < items.Length; i++)
                    {
                        array[i] = items[i];
                    }
                    array[count] = item;
                    ++count;
                    items = array;
                }

            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
        }

        public bool Remove(T item)
        {
            //If 'item' exists in the 'items' array, remove its first instance
            //Any items coming after the removed item should be shifted down so there is no empty index.
            //If 'item' was removed, return true. If no item was removed, return false.
            bool result = false;
            int index = 0;
            try
            {
                index = Array.IndexOf(items, item);
                if (index >= 0)
                {
                    result = true;
                    int i = 0;
                    while (i!=index)
                    {
                        i++;
                    }
                    while (i<items.Length-1)
                    {
                        items[i] = items[i + 1];
                        i++;
                    }
                    --count;
                }

            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
            return result;
        }

        public override string ToString()
        {
            //returns a single string that contains all items from array
            string sentance = "";
            bool loop = true;
            while (loop==true)
            {
                    for (int i = 0; i < count; i++)
                    {
                        string capIndex = items[i]?.ToString() + ", ";
                        sentance += capIndex;
                    }
                
                loop = false;
            }
            
            return sentance.Trim().TrimEnd(',');
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            return null;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            return null;
        }


    }
}
