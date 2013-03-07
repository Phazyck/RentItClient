﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentItProject.RentItReference;

namespace RentItProject
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new RentItServiceClient())
            {
                // Insert code here! =D
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(client.Next());
                }
                var arr = new int[] {2,3,5,7,11,13};
                var nodes = client.ToNodes(arr);
                var n = nodes.Next;
                while (n != null)
                {
                    var e = n.Element;
                    Console.WriteLine(e);
                    n = n.Next;
                }
                Console.WriteLine("Press [Enter] to exit.");
                Console.ReadLine();
            }
        }
    }
}
