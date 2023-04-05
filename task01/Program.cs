using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Task18();
        }
        static void Task01()
        {
            Console.WriteLine(" hello world");
            Console.Write("Hello world");

            Console.ReadKey();
        }
        static void Task02()
        {
            float x = 2.4F;
            Console.Write("this is :");
            Console.WriteLine(x);
            Console.ReadKey();

        }
        static void Task03()
        {
            Console.WriteLine("Input:");
            string x;
            x = Console.ReadLine();
            Console.ReadKey();
        }
        static void Task04()
        {
            Console.WriteLine("Input : ");
            string x = Console.ReadLine();
            int num = int.Parse(x);
            Console.WriteLine("in put is: {0}", num);
            Console.ReadKey();

        }
        static void Task05()
        {
            string x;
            Console.Write("lenght of squre: ");
            x = Console.ReadLine();
            int Lenght = int.Parse(x);
            int totalLenght = Lenght * Lenght;
            Console.Write("this is result:{0} ", totalLenght);
            Console.ReadKey();
        }
        static void Task06()
        {
            string x = "ahskhka adsa djal";
            Console.Write("this is :");
            Console.WriteLine(x);
            Console.ReadKey();
        }
        static void Task07()
        {
            char x = 'a';
            Console.Write("this is :");
            Console.WriteLine(x);
            Console.ReadKey();
        }
        static void Task08()
        {
            int x = 2;
            Console.Write("this is :");
            Console.WriteLine(x);
            Console.ReadKey();
        }

        static void Task09()
        {

            Console.WriteLine("Input: ");
            int input = int.Parse(Console.ReadLine());
            if (input > 50)
            {
                Console.WriteLine("You have Passed");
            }
            else
            {
                Console.Write("You have fail");
            }
            Console.Read();
        }
        static void Task10()
        {
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("ad kdas");
            }
            Console.ReadKey();
        }
        static void Task11()
        {
            int x = 0;
            while (x != 4)
            {
                Console.Write("Input: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Your Input: {0}", x);
            }
            Console.ReadKey();
        }
        static void Task12()
        {
            int x = 0;
            int sum = 0;
            do
            {
                Console.WriteLine("Input: ");
                x = int.Parse(Console.ReadLine());
                sum = sum + x;
            }
            while (x != 0);
            Console.WriteLine("Total:{0}", sum);
            Console.ReadKey();
        }
        static void Task13()
        {
            int[] arr = new int[5];
            for (int x = 0; x < 5; x++)
            {
                Console.Write("Input {0} : ", x);
                arr[x] = int.Parse(Console.ReadLine());

            }
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Input no {0} :  {1} ", x, arr[x]);
            }
            int largest = arr[0];
            for (int x = 1; x < 5; x++)
            {
                if (largest < arr[x])
                {
                    largest = arr[x];
                }
            }
            Console.Write("largest:{0}", largest);
            Console.ReadKey();
        }
        static void Task14()
        {
            Console.Write("Age:");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Price of machine:");
            int machine = int.Parse(Console.ReadLine());
            Console.Write("Toy price:");
            int toy = int.Parse(Console.ReadLine());
            int evenamount = 10;
            int totalamount = 0;
            for (int x = 1; x <= age; x++)
            {
                if (x % 2 == 0)
                {
                  
                    totalamount = totalamount + evenamount;
                    totalamount--;
                    evenamount = evenamount + 10;
                }
     
                else
                {
                    totalamount = totalamount + toy;
                }
            }

            if(totalamount<machine)
            {
                int x = machine - totalamount;
                Console.WriteLine("No{0}", x);
            }
            else
            {
                int x = totalamount-machine;
                Console.WriteLine("yes{0}", x);
            }
            Console.WriteLine(totalamount);
            Console.ReadKey();

        }
        static void Task15()
        {
            Console.WriteLine("enter no: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter no: ");
            int num2 = int.Parse(Console.ReadLine());
            int result = add(num1,num2);
            Console.Write("result: {0}", result);
            Console.ReadKey();
        }
        static int add(int num1,int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
        static void Task16()
        {
            string path = "C:\\Users\\DELL\\source\\repos\\task01\\abc.txt";
            if (File.Exists(path))
  
            {
                StreamReader load = new StreamReader(path);
                string y;
                while((y=load.ReadLine())!=null)
                {
                    
                    
                        Console.WriteLine(y);
                    
                }
                load.Close();

            }
            else
            {
                Console.WriteLine("Not exist!");
            }
            Console.ReadKey();
        }

        static void Task17()
        {
            string path = "C:\\Users\\DELL\\source\\repos\\task01\\abc.txt";
            StreamWriter y = new StreamWriter(path, true);
            y.Write("hello world");
            y.Flush();
            y.Close();
            Console.ReadKey();
        }
        static void Task18()
        {
            string path = "C:\\Users\\DELL\\source\\repos\\task01\\abc.txt";
            string[] name=new string[5];
            string[] password = new string[5];
            int option;
            do
            {
                ReadData(path, name, password);
                Console.Clear();
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.WriteLine("enter name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter password: ");
                    string p = Console.ReadLine();
                    SignIn(n, p, name, password);
                }
                else if (option == 2)
                {
                    Console.WriteLine("enter name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter password: ");
                    string p = Console.ReadLine();
                    SignUp(path, n, p);
                }
            } while (option < 3);
            Console.ReadKey();
        }
        static int menu()
        {
            int option;
            Console.WriteLine("1.SignIn");
            Console.WriteLine("2.SignUp");
            Console.WriteLine("Enter Option: ");
             option = int.Parse(Console.ReadLine());
            return option;
        }
        static string ParseData(string record,int field)
        {
            int comma = 1;
            string item = "";
            for(int x=0;x< record.Length;x++)
            {
                if(record[x]==',')
                {
                    comma++;
                }
                else if(comma==field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        static void ReadData(string path,string[] name,string[] password)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader load = new StreamReader(path);
                string record;
                while((record=load.ReadLine())!=null)
                {
                    name[x] = ParseData(record, 1);
                    password[x] = ParseData(record, 2);
                    x++;
                    if(x>=5)
                    {
                        break;
                    }
                }
                load.Close();
            }
            else
            {
                Console.WriteLine("not exist!");
            }
            
        }
        static void SignIn(string n,string p,string[] name,string[] password)
        {
            bool flag = false;
            for(int i=0;i<5;i++)
            {
                if(n==name[i]&& p==password[i])
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                }
            }
            if(flag==false)
            {
                Console.WriteLine("Invalid User");
            }
            Console.ReadKey();
        }

        static  void SignUp(string path,string n,string p)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(n + "," + p);
            file.Flush();
            file.Close();
        }
        

    }
}
