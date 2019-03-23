using System;
using System.IO;

namespace DocumentMerger2
{
    class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("DocumentMerger2 <input_file_1> <input_file_2> ... <input_file_n> <output_file>");
                Console.WriteLine("Supply a list of text files to merge followed by the name of the resulting merged text file as command line arguments.");
            }
            else
            {
                String outputfile = args[args.Length - 1];
                StreamWriter sw = new StreamWriter(outputfile);

                try
                {
                    String line = null;
                    int count = 0;

                    while (count < (args.Length - 1))
                    {
                        using (StreamReader sr = new StreamReader(args[count]))
                        {
                            while ((line = sr.ReadLine()) != null)
                            {
                            sw.WriteLine(line);
                            }
                        }
                        
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception, " + e.Message);
                }

                finally
                {
                    sw.Close();
                }

             Console.WriteLine("{0} was successfully saved.");
            }

        }
    }
}