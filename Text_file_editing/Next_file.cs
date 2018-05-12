using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace Text_file_editing
{
    class new_file
    {
        private string capture;

        static void Main(string[] args)

        {
            string capture; 
            new_file p = new new_file();
            string temp;
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\anand.prakash\Documents\siemenswithnoas.txt");
            Regex regex = new Regex(@"DEFINE\s+ABSTRACT\s+TABLE(.*)");

            for (int i = 0; i < lines.Length; i++)
            {

                Match match = regex.Match(lines[i]);

                // string l1;
                if (match.Success)
                {
                    string s = match.Value.ToString();

                    //line.Insert(1, s + "_columns_firstfive");
                    // line = line.Replace(s, s + "_columns_firstfive");
                    //lines[i] = lines[i].Replace(s, s + "_columns_firstfive");
                    //Console.Read();

                    //string gs;
                    //line.(gs);


                }

            }
            p.replace_more(ref lines, "anand");

            File.WriteAllLines(@"C:\Users\anand.prakash\Documents\vernit_xtends.txt", lines);

        }




        void replace_more(ref string[] lines, string temp)
        {
            Regex regex = new Regex(@"DEFINE\s+ABSTRACT\s+TABLE\s+(\w+)_columns");
            Regex regex3 = new Regex(@"\s*COLUMN\s+\w+\s+\[s\(\d+\)\:n\]\s+\<label\=\'");
            //Regex regex2 = new Regex(@"DEFINE\s+ABSTRACT\s+TABLE\s+.*_col");
            string s;
            //string l1;
            temp = null;

            
            for (int i = 0; i < lines.Length; i++)
            {   //Match match3 = regex3.Match(lines[i]);
                Match match = regex.Match(lines[i]);
                Match match2 = regex3.Match(lines[i]);

                
                if (match.Success)
                {
                    Console.WriteLine(match.Success);
                    capture = match.Groups[1].Value;
                    Console.WriteLine(capture);

                    
                }
                //Console.WriteLine(capture); // Prints a


                /*if (match2.Success)
                {
                    s = match2.Value.ToString();
                    temp = s;
                    //Console.WriteLine(temp);
                    
                }*/

                //Console.WriteLine(match.Success);
                if (match2.Success)
                {
                    //Console.WriteLine(capture);
                    //Console.WriteLine(lines[i]);
                    string repl = match2.Value.ToString();
                    //Console.WriteLine(repl);
                    lines[i] = lines[i].Replace(repl, repl + " " + capture);
                    //Console.WriteLine("hhhh");

                }
            }
        }

    }
}




