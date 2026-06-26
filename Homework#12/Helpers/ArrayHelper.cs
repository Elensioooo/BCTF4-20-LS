using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12.Helpers
{
    internal class ArrayHelper
    {
        public static void Add<T>(ref T[] arrayList, T newItem)
        {
            if (arrayList == null)
                throw new ArgumentNullException(nameof(arrayList));
            
            int index = arrayList.Length;
            Array.Resize(ref arrayList, index + 1);
            arrayList[index] = newItem;
        }

    }
}
