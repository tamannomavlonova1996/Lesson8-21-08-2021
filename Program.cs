using System;

namespace Lesson7_21_08_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArrStrings = {"a", "b", "c", "d", "e"};
            int[] myArrInt = {1, 2, 3, 4, 5, 6, 7};
            double[] myArrDouble = {5.1, 5.2, 5.3, 5.4, 5.5, 5.6};
            Decimal[] myArrDecimal = {2.1m, 2.2m, 2.3m, 2.4m, 2.5m};
            float[] myArrFloat = {6.1f, 6.2f, 6.3f, 6.4f, 6.5f};
            Console.WriteLine($"decimial is {ArrayHelper.Shift(ref myArrDecimal)}");
        }
    }

    public static class ArrayHelper
    {
        public static string Pop(ref string[] arr)
        {
            string last = arr[^1];
            string[] newArr = new string[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
                newArr[i] = arr[i];
            arr = newArr;
            return last;
        }

        public static int Pop(ref int[] arr)
        {
            int last = arr[^1];
            int[] newArr = new int [arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
                newArr[i] = arr[i];
            arr = newArr;
            return last;
        }

        public static double Pop(ref double[] arr)
        {
            double last = arr[^1];
            double[] newArr = new double [arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
                newArr[i] = arr[i];
            arr = newArr;
            return last;
        }

        public static decimal Pop(ref decimal[] arr)
        {
            decimal last = arr[^1];
            decimal[] newArr = new decimal[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
                newArr[i] = arr[i];
            arr = newArr;
            return last;
        }

        public static float Pop(ref float[] arr)
        {
            float last = arr[^1];
            float[] newArr = new float [arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
                newArr[i] = arr[i];
            arr = newArr;
            return last;
        }

        public static int Push(ref string[] arr, string val)
        {
            
            string[] newArr = new string[arr.Length+1];
            newArr[arr.Length]=val;
            for (int i = 0; i < arr.Length ; i++)
                newArr[i] = arr[i];
            arr = newArr;
            return arr.Length; 
        }
        public static int Push(ref int[] arr, int val)
        {
            
            int[] newArr = new int [arr.Length+1];
            newArr[arr.Length]=val;
            for (int i = 0; i < arr.Length ; i++)
                newArr[i] = arr[i];
            arr = newArr;
            return arr.Length; 
        }
        public static int Push(ref double[] arr, double val)
        {
            
            double [] newArr = new double[arr.Length+1];
            newArr[arr.Length]=val;
            for (int i = 0; i < arr.Length ; i++)
                newArr[i] = arr[i];
            arr = newArr;
            return arr.Length; 
        }
        public static int Push(ref decimal[] arr, decimal val)
        {
            
            decimal[] newArr = new decimal [arr.Length+1];
            newArr[arr.Length]=val;
            for (int i = 0; i < arr.Length ; i++)
                newArr[i] = arr[i];
            arr = newArr;
            return arr.Length; 
        }
        public static int Push(ref float[] arr, float val)
        {
            
            float[] newArr = new float [arr.Length+1];
            newArr[arr.Length]=val;
            for (int i = 0; i < arr.Length ; i++)
                newArr[i] = arr[i];
            arr = newArr;
            return arr.Length; 
        }
        public static string Shift(ref string[] arr)
        {
            string last = arr[0];
            string[] newArr = new string[arr.Length - 1];
            for (int i = 1; i < arr.Length ; i++)
                newArr[i-1] = arr[i];
            arr = newArr;
            return last;
        }

        public static int Shift(ref int[] arr)
        {
            int last = arr[0];
            int[] newArr = new int [arr.Length - 1];
            for (int i = 1; i < arr.Length ; i++)
                newArr[i-1] = arr[i];
            arr = newArr;
            return last;
        }

        public static double Shift(ref double[] arr)
        {
            double last = arr[0];
            double[] newArr = new double [arr.Length - 1];
            for (int i = 1; i < arr.Length ; i++)
                newArr[i-1] = arr[i];
            arr = newArr;
            return last;
        }

        public static decimal Shift(ref decimal[] arr)
        {
            decimal last = arr[0];
            decimal[] newArr = new decimal[arr.Length - 1];
            for (int i = 1; i < arr.Length; i++)
                newArr[i-1] = arr[i];
            arr = newArr;
            return last;
        }

        public static float Shift(ref float[] arr)
        {
            float last = arr[0];
            float[] newArr = new float [arr.Length - 1];
            for (int i = 1; i < arr.Length; i++)
                newArr[i-1] = arr[i];
            arr = newArr;
            return last;
        }
        public static int UnShift(ref string[] arr, string val)
        {
            
            string[] newArr = new string[arr.Length+1];
            newArr[0]=val;
            for (int i = 0; i < arr.Length ; i++)
                newArr[i+1] = arr[i];
            arr = newArr;
            return arr.Length; 
        }
        public static int UnShift(ref int[] arr, int val)
        {
            
            int[] newArr = new int [arr.Length+1];
            newArr[0]=val;
            for (int i = 0; i < arr.Length ; i++)
                newArr[i+1] = arr[i];
            arr = newArr;
            return arr.Length; 
        }
        public static int UnShift(ref double[] arr, double val)
        {
            
            double [] newArr = new double[arr.Length+1];
            newArr[0]=val;
            for (int i = 0; i < arr.Length ; i++)
                newArr[i+1] = arr[i];
            arr = newArr;
            return arr.Length; 
        }
        public static int UnShift(ref decimal[] arr, decimal val)
        {
            
            decimal[] newArr = new decimal [arr.Length+1];
            newArr[0]=val;
            for (int i = 0; i < arr.Length ; i++)
                newArr[i+1] = arr[i];
            arr = newArr;
            return arr.Length; 
        }
        public static int UnShift(ref float[] arr, float val)
        {
            
            float[] newArr = new float [arr.Length+1];
            newArr[0]=val;
            for (int i = 0; i < arr.Length ; i++)
                newArr[i+1] = arr[i];
            arr = newArr;
            return arr.Length; 
        }
    }
}