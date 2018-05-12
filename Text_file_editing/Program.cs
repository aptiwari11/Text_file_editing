//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;
//using System.IO;

//namespace Text_file_editing
//{
//    class Program
//    {
//        //static void Main(string[] args)
            
//        {
//            Program p = new Program();
//            string temp;
//            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\anand.prakash\Documents\test_text.txt");
//            Regex regex = new Regex(@"DEFINE\s+ABSTRACT\s+TABLE(.*)");

//            new_file newf = new new_file();
            
//            for (int i = 0; i < lines.Length; i++)
//            {
//                Match match = regex.Match(lines[i]);

//                // string l1;
//                if (match.Success)
//                {
//                    string s = match.Value.ToString();

//                    //line.Insert(1, s + "_columns_firstfive");
//                    // line = line.Replace(s, s + "_columns_firstfive");
//                    lines[i] = lines[i].Replace(s, s + "_columns_firstfive");
//                    //Console.Read();

//                    //string gs;
//                    //line.(gs);


//                }
//                //== "DEFINE ABSTRACT TABLE ") ;
//                // lines[i] = "";
//                //else if (i == 3 && lines[i] == "RAFASD")
//                //lines[i] = "set SOURCEDOT=124";
//                // File.WriteAllText(@"C:\Users\anand.prakash\Documents\a_test.txt", l1);
//            }
//            p.replace_more(ref lines, "anand");

//            File.WriteAllLines(@"C:\Users\anand.prakash\Documents\vernit.txt", lines);

//        }


//        void replace_more(ref string[] lines ,string temp)
//        {
//            Regex regex = new Regex(@"AS\s+4");
//            Regex regex2 = new Regex(@"DEFINE\s+ABSTRACT\s+TABLE\s+.*_columns");
//            string s;
//            //string l1;
//            temp = null;

//            for (int i = 0; i < lines.Length; i++)
//            {
//                Match match = regex.Match(lines[i]);
//                Match match2 = regex2.Match(lines[i]);



//                if (match2.Success)
//                {
//                    s = match2.Value.ToString();
//                    temp = s;

//                }


//                if (match.Success)
//                {
//                    string repl = match.Value.ToString();
//                    lines[i] = lines[i].Replace(repl, repl + System.Environment.NewLine + System.Environment.NewLine + temp + System.Environment.NewLine);
//                }
//            }
//        }

//    }
//}
