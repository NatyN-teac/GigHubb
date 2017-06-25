using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Comparc

{

    class Assembler
    {

        private static int LC { set; get; }
        private static Hashtable hash { get; set; }
        public static Dictionary<string, int> AddressTable;


        static void WriteFile(string Filename)
        {
            File.WriteAllText(Filename, "hello world");
        }
        static void ReadFile(string FileName)
        {
            Console.WriteLine(File.ReadAllText(FileName));
            Console.WriteLine(File.ReadAllLines(FileName).Count());
        }

        static string[] storeInArray(string filename)
        {
            string[] store = { };

            store = File.ReadAllLines(filename);


            return store;
        }
        static string StoreInOneString(string fileName)
        {

            string reg = "";
            //Console.WriteLine(storeInArray(fileName).Length);
            for (int j = 1; j < storeInArray(fileName).Length; j++)
            {
                reg += storeInArray(fileName)[j];

            }
            // Console.Write(reg.ToArray()[0]);

            return reg;
        }





        static void Main(string[] args)
        {
            string Filename = @"C:\Users\Naty\Desktop\ComparkAssem\hhe.txt";



            int counter = 0;
            string lines;

            // Read the file and display it line by line.


            //string h = file.ReadLine();
            // Console.WriteLine(h.Count());
            // string[] k = h.Split(' ').ToArray();
            // int indexs = Array.IndexOf(k, "ORG");
            // int coun = Convert.ToInt32(indexs);
            // int cc = Int32.Parse(k[3]);
            // Console.WriteLine(k[coun + 1]);




            // counter++;
            string hil = File.ReadLines(Filename).ToArray()[0];
            System.IO.StreamReader file =
            new System.IO.StreamReader(Filename);
            if (hil.Contains("ORG"))
            {


                string h = file.ReadLine();
                Console.WriteLine(h.Count());
                string[] k = h.Split(' ').ToArray();
                int i = 0;
                int indexs = Array.IndexOf(k, "ORG");
                int coun = Convert.ToInt32((k[indexs + 2]));
                LC = coun - 1;
                //Console.WriteLine(k[1]);
                while (i < h.Count())
                {
                    if (k[i].Length > 3)
                    {
                        AddressTable = new Dictionary<string, int>();
                        AddressTable.Add(k[i], LC);


                    }
                    i++;
                }
               
                Console.WriteLine("this is if the org", AddressTable["MIN"]);


            }
            else
            {
                LC = 0;
                Console.WriteLine($"this is if it is no org { LC }");
            }



            Console.WriteLine(LC);

            int lineNumber = File.ReadAllLines(Filename).Count();
            int cc = 0;
            while (cc < lineNumber)
            {
                string ender = File.ReadLines(Filename).ToString();
                if (ender.Contains("END"))
                {
                    break;
                }
                string[] liness = File.ReadLines(Filename).ToArray();
                LC++;
                // Console.WriteLine(liness[cc]);
                char[] brs = liness[cc].ToCharArray();
                int jj = 0;
                // Console.WriteLine(brs.Length);
                if (brs.Contains(','))
                {
                    int hiu = Array.IndexOf(brs, ',');

                    string CollectionOFlabel = " ";
                    // Console.Write(hiu);
                    int i = hiu - 3;
                    while (i != hiu)
                    {



                        CollectionOFlabel += (brs[i]).ToString();
                        Hashtable hash = new Hashtable();
                        hash.Add(CollectionOFlabel, LC);


                        i++;
                    }

                    ICollection key = hash.Keys;
                    foreach (var item in key)
                    {
                        Console.Write(item +":" + hash[item]);
                    }
                  
                    Console.Write(CollectionOFlabel);
                    Console.WriteLine(LC);
                    
                }

               

                cc++;
            }


            




            Console.Read();

        }
    }

}
