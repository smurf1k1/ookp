using lab1.Models;
using System;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person A = new Person();
            Person B = new Person();
            Person C = new Person();
            bool num1 = true;
            string[] variants = new string[3];
            variants[0] = "Нотаріус";
            variants[1] = "Слідчий";
            variants[2] = "Адвокат";
            while (num1 == true)
            {
                A.Arr = variants[0];
                B.Arr = variants[1];
                C.Arr = variants[2];
                if (C.Arr == "Нотаріус")
                {
                    C.Role1 = "Нотаріус";
                    B.Role1 = "Слідчий";
                    A.Role1 = "Адвокат";
                    C.Role2 = "Нотаріус";
                    B.Role2 = "Слідчий";
                    A.Role2 = "Адвокат";
                    C.Role3 = "Нотаріус";
                    B.Role3 = "Слідчий";
                    A.Role3 = "Адвокат";
                }
                if (C.Arr != "Слідчий")
                {
                    B.Role1 = "Адвокат";
                    B.Role2 = "Слідчий";
                    B.Role3 = "Слідчий";
                    C.Role1 = "Нотаріус";
                    C.Role2 = "Адвокат";
                    C.Role3 = "Адвокат";
                    A.Role1 = "Нотаріус";
                    A.Role2 = "Слідчий";
                    A.Role3 = "Адвокат";
                }
                if (B.Arr == "Слідчий" || B.Arr == "Нотаріус")
                {
                    C.Role1 = "Слідчий";
                    C.Role2 = "Нотаріус";
                    C.Role3 = "Нотаріус";
                    A.Role1 = "Нотаріус";
                    A.Role2 = "Слідчий";
                    A.Role3 = "Адвокат";
                    B.Role1 = "Нотаріус";
                    B.Role2 = "Слідчий";
                    B.Role3 = "Слідчий";
                }
                if (A.Arr == "Адвокат")
                {
                    A.Role1 = "Адвокат";
                    A.Role2 = "Адвокат";
                    A.Role3 = "Адвокат";
                    C.Role1 = "Слідчий";
                    C.Role2 = "Слідчий";
                    C.Role3 = "Слідчий";
                    B.Role1 = "Нотаріус";
                    B.Role2 = "Нотаріус";
                    B.Role3 = "Нотаріус";
                }
                if (A.Arr == "Нотаріус")
                {
                    A.Role1 = "Нотаріус";
                    A.Role2 = "Нотаріус";
                    A.Role3 = "Нотаріус";
                    C.Role1 = "Адвокат";
                    C.Role2 = "Адвокат";
                    C.Role3 = "Адвокат";
                    B.Role1 = "Слідчий";
                    B.Role2 = "Слідчий";
                    B.Role3 = "Слідчий";
                }
                if (A.Role1 != B.Role1 && A.Role1 != C.Role1 && B.Role1 != C.Role1)
                {
                    num1 = false;
                    Console.WriteLine("A " + A.Role1 + " B " + B.Role1 + " C " + C.Role1);
                }
                if (A.Role2 != B.Role2 && A.Role2 != C.Role2 && B.Role2 != C.Role2)
                {
                    num1 = false;
                    Console.WriteLine("A " + A.Role2 + " B " + B.Role2 + " C " + C.Role2);
                }
                if (A.Role3 != B.Role3 && A.Role3 != C.Role3 && B.Role3 != C.Role3)
                {
                    num1 = false;
                    Console.WriteLine("A " + A.Role3 + " B " + B.Role3 + " C " + C.Role3);
                }
                {
                    string k = variants[1];
                    variants[1] = variants[2];
                    variants[2] = variants[0];
                    variants[0] = k;
                }
            }

        }
    }
}
