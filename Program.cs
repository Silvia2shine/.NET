namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare new array
            int[] myArray = new int[3];
            myArray[0] = 35;
            myArray[1] = -10;
            myArray[2] = 500;

            string[] daysOfTheWeek = { "Luni", "Marti", "Miercuri" }; // reprezentare inline

            // accessing elements from an array
            string[] reverseDays = new string[6];
            int lenght = daysOfTheWeek.Length;
            for (int i = 0; i < lenght; i++)
            {
                reverseDays[lenght - i - 1] = daysOfTheWeek[i];
            }
            Console.WriteLine(reverseDays[0]);

            //printing an array

            for (int i = 1; i < lenght; i++)
            {
                Console.WriteLine(daysOfTheWeek[i]);
            }

            foreach (string item in daysOfTheWeek)
            {
                Console.WriteLine(item);
            }
            //while
            int index = 0;
            while (index < daysOfTheWeek.Length)
            {
                Console.WriteLine(daysOfTheWeek[index]);
                index++;
            }

            index = 0;
            do
            {
                // Console.WriteLine(daysOfTheWeek[index]);
                index++;
            } while (index < daysOfTheWeek.Length);

            // reading array from console
            Console.WriteLine("Please give an array size");
            int arraySize = int.Parse(Console.ReadLine());
            int[] myArrayFromConsole = new int[arraySize];

            Console.WriteLine(" Plz input the values of the array");
            for (int i = 0; i < arraySize; i++)
            {
                myArrayFromConsole[i] = int.Parse(Console.ReadLine());
            }
            // copy an array
            string[] myArrayCopy = daysOfTheWeek;
            myArrayCopy[0] = "aksjdje";
            //....

            string[] myArrayClone = (string[])daysOfTheWeek.Clone();
            myArrayClone[0] = "Duminica";
            Console.WriteLine(myArrayClone[0]);
            Console.WriteLine(daysOfTheWeek[0]);

            //resize an array

            int[] intArray = new int[5];
            int[] copyArray = intArray; // create backup

            intArray = new int[6];

            for (int i = 0; i < 5; i++)
            {
                intArray[i] = copyArray[i];
            }

            intArray[5] = 10;


            //declare and create  matrix

            int[,] myMatrix =
            {
                {1,2 },
                { 2,3 }
            };
            int[,] myM = new int[2, 2];
            myM[0, 0] = 1;

            //printing matrix

            for (int i = 0; i < myM.GetLength(0); i++)
            {
                for (int j = 0; j < myM.GetLength(1); j++)
                {
                    Console.WriteLine(myM[i, j]);
                    Console.Write(", ");
                }
                Console.WriteLine();
            }

            // eading a matrix from console

            Console.WriteLine("Introdu dim matricei");
            Console.WriteLine("Nr de randuri");
            int nrRanduri = int.Parse(Console.ReadLine());

            Console.WriteLine("Nr de coloane");
            int nrColoane = int.Parse(Console.ReadLine());

            int[,] matriceaMea = new int[nrRanduri, nrColoane];

            for (int i = 0; i < nrRanduri; i++)
            {
                for (int k = 0; k < nrColoane; k++)
                {
                    Console.WriteLine("Scrie valoarea pentru randul " + i + " si coloana " + k + ":");
                    matriceaMea[i, k] = int.Parse(Console.ReadLine());
                }

            }
            // Jagged arrays

            int[][] jagged = new int[3][]; // 3 arrayuri care pot avea dimensiuni diferite

            //int[][] jagged = new int[3][];
            jagged[0][0] = 15;

            // property of class array

            string[] capitals = { "Sofia", "Madrid" };

            Console.WriteLine($"Lungimea array ului este: {capitals.Length}");
            Console.WriteLine($"Nr de dimensiuni este array ului este: {capitals.Rank}");

            Console.WriteLine($"Poz orasului Sofia este {Array.IndexOf(capitals, "Sofia")}");
            Console.WriteLine($"La poz 0 se afla orasul {capitals[0]}.");

            var reversed = capitals.Reverse();

            // Array.Reverse(capitals); 

            foreach (var city in reversed)
            {
                Console.WriteLine(city);
            }

            Array.Sort(capitals);
            foreach (var city in capitals)
            {
                Console.WriteLine(city);
            }


            Array.Clear(capitals);
        }


    }
}
