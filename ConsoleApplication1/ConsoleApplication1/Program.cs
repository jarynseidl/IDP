﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(args.Length);
            System.Console.WriteLine("Hello World");
            IDP myIDP = new IDP();
            DAO.IDP_DAO myIDPDAO = new DAO.IDP_DAO();
            eWFMConn.getSingleton();
        }
    }
}
