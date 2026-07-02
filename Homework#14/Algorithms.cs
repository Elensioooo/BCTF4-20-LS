using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_14
{
    internal class Algorithms 
    {
        public static IEnumerable<T> MyWhere<T>(IEnumerable<T> collection, Func<T, bool> method)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            List<T> resultCollection = new List<T>();
            foreach (var item in collection)
            {
                bool result = method(item);
                if (result == true)
                    resultCollection.Add(item);
            }
            return resultCollection;
        }

        //????OrderBy - 
        //ალბათ აქ უკეთესი სოლუშენი Comparer<T>.Default.Compare(leftValue, rightValue)
        // <0 - left is smaller
        // =0 - Left equals right
        // >0 - left is grater 
        public static IEnumerable<T1> MyOrderBy<T1,T2>(IEnumerable<T1> collection, Func<T1, T2> method, Func<T2, T2, int> compare)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            List<T1> list = new List<T1>(collection);
            for(int i = 0; i < list.Count; i++)
            {
                for(int j = 0; j < list.Count - 1 - i; j++)
                {
                    var leftValue = method(list[j]);
                    var rightValue = method(list[j + 1]);
                    if(compare(leftValue, rightValue) > 0)
                    {

                        T1 temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return list;
        }

        public static T MyFirst<T>(IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));
            
            foreach(var item in collection)
            {
                return item;
            }
            return default;
        }

        public static T MyFirstOrDefault<T>(IEnumerable<T> collection, Predicate<T> method)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));
            foreach(var item in collection)
            {
                if (method(item))
                    return item;
            }
            return default;
        }

        public static T MySingle<T>(IEnumerable<T> collection, Predicate<T> method)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            int count = 0;
            T result = default;
            foreach(var item in collection)
            {
                if (method(item))
                {
                    result = item;
                    count++;
                }
                    
            }

            if (count == 0)
                throw new ArgumentException("No matching item");
            if (count > 1)
                throw new ArgumentException("more than one matching item");

            return result;
        }

        public static T MySingleOrDefault<T>(IEnumerable<T> collection, Predicate<T> method)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            int count = 0;
            T result = default;
            foreach (var item in collection)
            {
                if (method(item))
                {
                    result = item;
                    count++;
                }

            }

            if (count == 0)
                return default;
            if (count > 1)
                throw new ArgumentException("more than one matching item");

            return result;
        }

        public static bool myAny<T>(IEnumerable<T> collection, Predicate<T> method)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));
            foreach(var item in collection)
            {
                if (method(item))
                    return true;
            }
            return false;
        }

        public static bool myAll<T>(IEnumerable<T> collection, Predicate<T> method)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));
            
            
            foreach (var item in collection)
            {
                if (!method(item))
                    return false;
            }
            return true;
        }

        public static int myCount<T>(IEnumerable<T> collection, Predicate<T> method)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            int count = 0;
            if (method != null)
            {
               foreach(var item in collection)
               {
                    if (method(item))
                        count++;
               }
                return count;
            }

            foreach (var item in collection)
            {
                count++;
            }
            return count;
        }

        public static IEnumerable<T> MyDistinct<T>(IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            List<T> list = new List<T>(collection);
            List<T> resultCollection = new List<T>();
            for (int i = 0; i < list.Count; i++)
            {
                bool elementExists = false;
                for(int j = 0; j < resultCollection.Count; j++)
                {
                    if (list[i].Equals(resultCollection[j]))
                    {
                        elementExists = true;
                        break;
                    }
                }

                if (!elementExists)
                    resultCollection.Add(list[i]);
            }

            return resultCollection;
        }
    }
}
