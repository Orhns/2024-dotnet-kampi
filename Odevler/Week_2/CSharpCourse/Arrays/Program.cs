namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string student1 = "Orhun";
            //string student2 = "Ali";
            //string student3 = "Ayşe";

            //string[] students = new string[3];
            //students[0] = "Orhun";
            //students[1] = "Ali";
            //students[2] = "Ayşe";

            //foreach (string student in students) { Console.WriteLine(student); }

            //string[] students2 = { "Orhun", "Ali", "Ayşe" };
            //foreach (var student in students2) { Console.WriteLine(student); }


            string[,] regions = new string[5, 3]
            {
                {"Istanbul","Izmit","Balikesir"},
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Samsun","Trabzon" },
                {"Izmir","Muğla","Manisa" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("**************");
            }
        }
    }
}
