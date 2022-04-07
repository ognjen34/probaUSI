namespace HelloWorld
{

    class Hello
    {
        static void Main(string[] args)
        {
            string unos;
            Console.Write("Unos: ");
            unos = Console.ReadLine();
            while (unos != "x")
            {

                string[] tokens = unos.Split();
                if (tokens[1] == "+")
                {
                    Console.WriteLine(Convert.ToDouble(tokens[0]) + Convert.ToDouble(tokens[2]));
                }
                Console.Write("Unos: ");
                unos = Console.ReadLine();
                Console.WriteLine("Zarko nije car");
                Console.WriteLine("Angie nije carica");


            }


        }
    }

}