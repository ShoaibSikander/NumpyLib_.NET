using System;
using Numpy;
using System.Collections;
using System.Collections.Generic;

namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** var0 **");
            var var0 = new int[] { 11, 22, 33, 44 };
            Console.WriteLine(var0);
            Console.WriteLine(var0.GetType());
            Console.WriteLine("----------");

            Console.WriteLine("** var1 **");
            var var1 = np.ones(4);
            Console.WriteLine(var1);
            Console.WriteLine(var1.GetType());
            Console.WriteLine("----------");

            Console.WriteLine("** var2 **");
            var var2 = np.ones((3,3));
            Console.WriteLine(var2);
            Console.WriteLine(var2.GetType());
            Console.WriteLine("----------");

            Console.WriteLine("** var3 **");
            var var3 = np.zeros((2,2));
            Console.WriteLine(var3);
            Console.WriteLine(var3.GetType());
            Console.WriteLine("----------");

            Console.WriteLine("** var4 **");
            var var4 = np.zeros_like(var2);
            Console.WriteLine(var4);
            Console.WriteLine(var4.GetType());
            Console.WriteLine("----------");

            Console.WriteLine("** var5 **");
            var var5 = np.full((4,4), 3);
            Console.WriteLine(var5);
            Console.WriteLine(var5.GetType());
            Console.WriteLine("----------");

            Console.WriteLine("** var6 **");
            var var6 = np.asarray(var0);
            Console.WriteLine(var6);
            Console.WriteLine(var6.GetType());
            Console.WriteLine("----------");

            Console.WriteLine("** var7 **");
            var var7 = np.asanyarray(var0);
            Console.WriteLine(var7);
            Console.WriteLine(var7.GetType());
            Console.WriteLine("----------");

            Console.WriteLine("** var8 **");
            var var8 = np.ascontiguousarray(var0);
            Console.WriteLine(var8);
            Console.WriteLine(var8.GetType());
            Console.WriteLine("----------");

            Console.WriteLine("** var9 **");
            var var9 = np.copy(var0);
            Console.WriteLine(var9);
            Console.WriteLine(var9.GetType());
            Console.WriteLine("----------");

            Console.WriteLine("** var10 **");
            var var10 = np.arange(1, 10, 2);
            Console.WriteLine(var10);
            Console.WriteLine(var10.GetType());
            Console.WriteLine("----------");

            Console.WriteLine("** var11 **");
            var var11 = np.linspace(1, 10, 5);
            Console.WriteLine(var11);
            Console.WriteLine(var11.GetType());
            Console.WriteLine("----------");

            Console.WriteLine("** var12 **");
            var var12 = np.tri(5, 5, 1);
            Console.WriteLine(var12);
            Console.WriteLine(var12.GetType());
            Console.WriteLine("----------");

            Console.WriteLine("** var13 **");
            var var13 = var12.flatten();
            Console.WriteLine(var13);
            Console.WriteLine(var13.GetType());
            Console.WriteLine("----------");

            Console.WriteLine("** var14 **");
            var aa = np.zeros(2);
            var var14 = np.ones(2);
            var14 = np.append(var14, aa);
            Console.WriteLine(var14);
            Console.WriteLine(var14.GetType());
            Console.WriteLine("----------");

            Console.WriteLine("\n *** ========================================== *** \n");
            
            var arr1 = new int[] { 11, 22, 33, 44 };
            var arr2 = np.array(arr1)*2;
            var arr3 = arr2.repr;
            var arr4 = arr2.GetData<int>();
            NDarray arr5 = new int[] { 11, 22, 33, 44 };

            Console.WriteLine(arr1);
            Console.WriteLine(arr1.GetType());
            Console.WriteLine("----------");
            Console.WriteLine(arr2);
            Console.WriteLine(arr2.GetType());
            Console.WriteLine("----------");
            Console.WriteLine(arr3);
            Console.WriteLine(arr3.GetType());
            Console.WriteLine("----------");
            Console.WriteLine(arr4);
            Console.WriteLine(arr4.GetType());
            Console.WriteLine("----------");
            Console.WriteLine(arr5);
            Console.WriteLine(arr5.GetType());

            Console.WriteLine("\n *** ========================================== *** \n");

            NDarray a = new double[] { 1, 2, 3 };
            NDarray b = new double[,] { { 2, 3, 4 }, { 3, 0, 5 } };
            Dictionary<string, NDarray> ndd = new Dictionary<string, NDarray>();
            ndd.Add("f", a);
            ndd.Add("l", b);
            Console.WriteLine("No. of elements in dictionary: {0}", ndd.Count);
            Console.WriteLine("Keys of dictionary: {0}", ndd.Keys);
            Console.WriteLine("Values of dictionary: {0}", ndd.Values);
            Console.WriteLine("\n");
            IEnumerator enumerator = ndd.Keys.GetEnumerator();
            enumerator.MoveNext();
            object firstK = enumerator.Current;
            enumerator.MoveNext();
            object secondK = enumerator.Current;
            Console.WriteLine("First Key: {0}", firstK);
            Console.WriteLine("Second Key: {0}", secondK);
            IEnumerator enumeratorV = ndd.Values.GetEnumerator();
            enumeratorV.MoveNext();
            object firstV = enumeratorV.Current;
            enumeratorV.MoveNext();
            object secondV = enumeratorV.Current;
            Console.WriteLine("First Value: {0}", firstV);
            Console.WriteLine("Type: {0}", firstV.GetType());
            Console.WriteLine("Second Value: {0}", secondV);
            Console.WriteLine("Type: {0}", secondV.GetType());
            NDarray firstVunboxed = (NDarray)firstV;
            NDarray secondVunboxed = (NDarray)secondV;
            Console.WriteLine("First Value: {0}", firstVunboxed);
            Console.WriteLine("Type: {0}", firstVunboxed.GetType());
            Console.WriteLine("Second Valuey: {0}", secondVunboxed);
            Console.WriteLine("Type: {0}", secondVunboxed.GetType());
            Console.WriteLine("\n");
            np.savez_compressed("file.npz", null, ndd);
            var data_features_labels = np.load("file.npz");
            Console.WriteLine("Data type of loaded npz file: " + data_features_labels.GetType());

            Console.WriteLine("\n *** ========================================== *** \n");

            var varA = new int[] { 1, 2, 3 };
            IEnumerator enumVarA = varA.GetEnumerator();
            enumVarA.MoveNext();
            object firstElemVarA = enumVarA.Current;
            Console.WriteLine("First element of C# array: " + firstElemVarA);
            Console.WriteLine("C# array: " + varA);
            Console.WriteLine("Type: " + varA.GetType());
            Console.WriteLine("\n");
            NDarray varB = new int[] { 1, 2, 3 };
            Console.WriteLine("NDarray: " + varB);
            Console.WriteLine("Type: " + varB.GetType());
            var data = varB.GetData<int>();
            Console.WriteLine("C# array: " + data);
            Console.WriteLine("Type: " + data.GetType());

            Console.WriteLine("\n *** ========================================== *** \n");
        }
    }
}
