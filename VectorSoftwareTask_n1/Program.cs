using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorSoftwareTask_n1
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "WEAREDISCOVEREDFLEEATONCE";
            string result = "WECRLTEERDSOEEFEAOCAIVDEN";

            Console.WriteLine("Encoded-------------------");
            Console.WriteLine(result);
            Console.WriteLine(ENCODE(str, 3));
            string encoded = ENCODE(str, 3);


            Console.WriteLine("Decoded-------------------");
            Console.WriteLine(str);
            Console.WriteLine(DECODE(encoded, 3));
            string decoded = DECODE(encoded, 3);
            Console.WriteLine(string.Equals(encoded, result));
            Console.WriteLine(string.Equals(decoded, str));
            Console.WriteLine(ENCODE(String.Empty, 1));
        }
        static string ENCODE(string raw_to_encode, int rails)
        {
            if (string.IsNullOrWhiteSpace(raw_to_encode))
                return string.Empty;
            else if (rails < 2)
                return "Rails should be at least 2!";
            // char[,] encoded = new char[rails, raw_to_encode.Length];
            List<StringBuilder> raw_to_lines = new List<StringBuilder>();
            for (int i = 0; i < rails; i++)
            {
                raw_to_lines.Add(new StringBuilder());
            }

            int top = 1;
            int currentLine = 0;

            for (int i = 0; i < raw_to_encode.Length; i++)
            {
                raw_to_lines[currentLine].Append(raw_to_encode[i]);
                if (currentLine == 0)
                    top = 1;
                else if (currentLine == rails - 1)
                    top = -1;
                currentLine += top;
            }

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < rails; i++)
            {
                result.Append(raw_to_lines[i]);
            }

            return result.ToString();
        }

        static string DECODE(string raw_to_decode, int rails)
        {
            if (string.IsNullOrWhiteSpace(raw_to_decode))
                return string.Empty;
            else if (rails < 2)
                return "Rails should be at least 2!";

            List<StringBuilder> raw_to_lines = new List<StringBuilder>();
            for (int i = 0; i < rails; i++)
            {
                raw_to_lines.Add(new StringBuilder());
            }

            int top = 1;
            int currentLine = 0;

            int[] char_in_line = new int[rails];

            for (int i = 0; i < raw_to_decode.Length; i++)
            {
                char_in_line[currentLine]++;
                if (currentLine == 0)
                    top = 1;
                else if (currentLine == rails - 1)
                    top = -1;
                currentLine += top;
            }
            //foreach (var item in char_in_line)
            //{
            //    Console.WriteLine(item);
            //}

            int check = 0;
            for (int i = 0; i < rails; i++)
            {
                for (int j = 0; j < char_in_line[i]; j++)
                {
                    raw_to_lines[i].Append(raw_to_decode[check]);
                    check++;
                }
            }

            //Console.WriteLine("checking lines ___________________________");
            //foreach (var item in raw_to_lines)
            //{
            //    Console.WriteLine(item);
            //}

            StringBuilder result = new StringBuilder();
            currentLine = 0;
            top = 1;

            int[] track_line = new int[rails];
            for (int i = 0; i < raw_to_decode.Length; i++)
            {
                result.Append(raw_to_lines[currentLine][track_line[currentLine]]);
                track_line[currentLine]++;
                if (currentLine == 0)
                    top = 1;
                else if (currentLine == rails - 1)
                    top = -1;
                currentLine += top;
            }

            return result.ToString();
        }
    }
}
