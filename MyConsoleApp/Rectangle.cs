namespace MyConsoleApp
{
    public class Rectangle //: Shape
    {
        //public int Width { get; set; }
        //public int Height { get; set; }

        //public Rectangle(int width, int height)
        //{
        //    Width = width;
        //    Height = height;
        //}

        //public override double GetArea()
        //{
        //    return Width * Height;
        //}

        //public string RandomNumbers(int num)
        //{
        //    Random random = new Random();
        //    var result = random.Next(num) + 1;               
        //    return $"REC/{result}/";
        //}


        //public void PrintCount()
        //{
        //    List<int> listInt = new List<int>();
        //    List<double> listDouble = new List<double>();

        //    while (true)
        //    {
        //        Console.Write("Enter integer/double number: ");
        //        string input = Console.ReadLine();

        //        if (int.TryParse(input, out int numInt))
        //        {
        //            listInt.Add(numInt);
        //        }
        //        else if (double.TryParse(input, out double numDouble))
        //        {
        //            listDouble.Add(numDouble);
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }

        //    Console.Write("You enter {0} ints: ", listInt.Count);
        //    foreach (var item in listInt)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine();

        //    Console.Write("You enter {0} doubles: ", listDouble.Count);
        //    foreach (var item in listDouble)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine();
        //}

        

        public void ReadFile(string file)
        {
            try
            {
                TextReader reader = new StreamReader(file);
                string line = reader.ReadLine();
                Console.WriteLine(line);
                reader.Close();
            }
            catch (FileNotFoundException ff)
            {
                Console.WriteLine("The file {0} is not found ", file);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.StackTrace);
            }
        }
    }
}
