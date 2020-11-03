using System;

namespace Datentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            long Ganzzahl64Bit;         // -9 Trillionen bis +9 Trillionen
            ulong Ganzzahl64Bitunsigned;         // 0 bis +18 Trillionen

            int Ganzzahl32Bit;          // -2,14 Milliarden bis +2,14 Milliarden
            uint Ganzzahl32BitPositiv; // 0 bis +4,29 Milliarden

            short Ganzzahl16Bit;        // -32 tausend bis +32 tausend
            ushort Ganzzahl16BitPositiv; // 0 bis 65535 (2 Byte Zahl)


            sbyte Ganzzahl8Bit;     // -128 bis +127
            byte Ganzzahl8BitPositiv; // 0 bis 255

            //////////////////////////////////////////////////////

            float Gleitkommazahl32Bit;   // ca 6 Stellen genau
            double Gleitkommazahl64Bit; // ca. 15 Stellen genau
            decimal Gleitkommazahl128Bit;

            /////////////////////////////////////////////////////

            bool JaoderNein; // exakt zwei. true(1) und false(0)

            /////////////////////////////////////////////////////
            byte AktiveOptionen = (byte)(MyEnum.A | MyEnum.D); 
            Console.WriteLine("byte AktiveOptionen" +AktiveOptionen);

            byte AktiveOptionen = (byte)(MyEnum.A | MyEnum.D);
            Console.WriteLine("byte AktiveOptionen2" + AktiveOptionen);
        }// Ende main

        enum MyEnum
        {
            A = 1,      //A=0001
            B = A * 2,  //B=0010
            C = B * 2,  //C=0100
            D = C * 2  //D=1000
        }
    }
}
