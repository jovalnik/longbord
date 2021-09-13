namespace longbord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur många bord?");
            int antalBord = 0;
            int platser= 0;
            bool success = int.TryParse(Console.ReadLine(), out antalBord);
            platser = Platser(antalBord);
            Console.WriteLine("Det blir "+platser+" platser");
            //Console.WriteLine(" form? (+ för korsform)");
            //int mittBord = antalBord - 2;
            //const int kantBord = 2;
            //int personer = kantBord * 3 + mittBord * 2;
            //Console.WriteLine("det bli plats för "+personer+ " personer");
        }

        static int Platser(int bord)
        {
            const int sidoPlatser = 2;
            const int kantPlatser = 2;
            int platser = bord * sidoPlatser + kantPlatser;
            return platser;
        }
    }
}
