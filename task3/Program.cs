using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            RecPoint[] arr = new RecPoint[4];
            Console.WriteLine("-------enter the rectangle point");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("enetr point{0}: ",i+1);
                Console.Write("enetr x=");
                arr[i] = new RecPoint() { pointX = 0, pointY = 0,pointName="x"+(i+1)};
                arr[i].pointX=int.Parse(Console.ReadLine());
                Console.Write("enetr y=");
                arr[i].pointY = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("--displaying the Rec points:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{2}--> ({0},{1})",arr[i].pointX,arr[i].pointY,arr[i].pointName);
            }

            Console.WriteLine("display the array after sorting it");
            RecPoint[] res= pointDirectionVer(arr);
            RecPoint[] hroz = pointDirectionHor(res);
            Console.WriteLine("{1}-{0} NORTH ", res[2].pointName, res[3].pointName);
            Console.WriteLine("{1}-{0} EAST", hroz[2].pointName, hroz[3].pointName);
            Console.WriteLine("{1}-{0} SOUTH", res[0].pointName, res[1].pointName);
            Console.WriteLine("{0}-{1} WEST", hroz[0].pointName, hroz[1].pointName);
           


            Console.ReadLine();

        }


        //function to show the north and south points
        public static RecPoint[] pointDirectionVer(RecPoint[]arr)
        {
         
            arr = arr.OrderBy(a => a.pointY).ToArray();
            return arr;
           
        }

        public static RecPoint[] pointDirectionHor(RecPoint[] arr)
        {

            arr = arr.OrderBy(a => a.pointX).ToArray();
            return arr;

        }


    }
}
