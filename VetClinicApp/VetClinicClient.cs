﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace VetClinicApp
{
    public class VetClinicClient
    {

        static void Main(string[] args)
        {
            Starter starter = new Starter();
            starter.Start();

            starter.InitConnection();
        }
    }
}