using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProgram
{
    public class CustomList<T> : IEnumerable
    {
        private int count;
        private int capacity;

        private T[] arr;

        public int Count { get { return count; } private set { count = value; } }
        public int Capacity { get { return capacity; } private set { capacity = value; } }

        public CustomList()
        {
            count = 0;
            capacity = 4;
            arr = new T[capacity];
        }

        // Define the indexer to allow client code to use [] notation.
        public T this[int i] => arr[i];

        public void Add(T item)
        {
            if (count == capacity)
            {
                Grow();
            }
            arr[count] = item;
            count++;
        }


        public void Remove(T item)
        {
            int foundIndex = count;
            bool doesRemove = false;

            for (int i = 0; i < count; i++)
            {
                if (arr[i].Equals(item)) 
                {
                    foundIndex = i;
                    doesRemove = true;
                    break;
                }
            }  

            if (doesRemove)
            {
                if (count == capacity)
                {
                    for (int i = foundIndex; i < count - 1; i++)
                    {
                        arr[i] = arr[i + 1];
                    }
                    arr[count - 1] = default(T);
                }
                else
                {
                    for (int i = foundIndex; i < count; i++)
                    {
                        arr[i] = arr[i + 1];
                    }
                    arr[count] = default(T);
                }
                count--;
                if (count == (capacity / 2))
                {
                    Shrink();
                }
                doesRemove = false;
            }

            

        }

        public override string ToString()
        {
            string charSet = "";
            for (int i = 0; i < count - 1; i++)
            {
                charSet = charSet + (arr[i].ToString() + ", ");
            }
            charSet += arr[count-1];
            return charSet;
        }

        public void Grow()
        {
            T[] oldArr = arr;
            arr = new T[capacity * 2];

            for (int i = 0; i < capacity; i++)
            {
                arr[i] = oldArr[i];
            }

            capacity = capacity * 2;
        }

        public void Shrink()
        {
            T[] oldArr = arr;
            arr = new T[capacity * 2];

            for (int i = 0; i < capacity; i++)
            {
                arr[i] = oldArr[i];
            }

            capacity = capacity / 2;
        }

        public static CustomList<T> operator +(CustomList<T> List1, CustomList<T> List2)
        {
            CustomList<T> concatList = new CustomList<T>();
            concatList = List1;
            for (int i = 0; i < List2.count; i++)
            {
                concatList.Add(List2[i]);
            }
            return concatList;
        }

        public static CustomList<T> operator -(CustomList<T> List1, CustomList<T> List2)
        {
            CustomList<T> filteredList = new CustomList<T>();
            for (int i = 0; i < (List2.count); i++)
            {
                for (int j = 0; j < (List1.count); j++)
                {
                    if (List2[i].Equals(List1[j]))
                    {
                        List1.Remove(List2[i]);
                        break;
                    }
                }
            }
            filteredList = List1;
            return filteredList;
        }

        public CustomList<T> Zip(CustomList<T> secondArr)
        {
            CustomList<T> newArr = new CustomList<T>();

            if (count == secondArr.count)
            {
                for (int i = 0; i < count; i++)
                {
                    newArr.Add(arr[i]);
                    newArr.Add(secondArr[i]);
                }
            }
            else if (count < secondArr.count)
            {
                for (int i = 0; i < count; i++)
                {
                    newArr.Add(arr[i]);
                    newArr.Add(secondArr[i]);
                }
                for (int i = count; i < secondArr.count; i++)
                {
                    newArr.Add(secondArr[i]);
                }
            }
            else if (count > secondArr.count)
            {
                for (int i = 0; i < secondArr.count; i++)
                {
                    newArr.Add(arr[i]);
                    newArr.Add(secondArr[i]);
                }
                for (int i = secondArr.count; i < count; i++)
                {
                    newArr.Add(arr[i]);
                }
            }
            return newArr;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return arr[i];
            }
        }
    }
}
