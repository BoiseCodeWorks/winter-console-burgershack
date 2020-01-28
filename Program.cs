﻿using System;
using System.Collections.Generic;
using burgershack.Controllers;
using burgershack.Interfaces;
using burgershack.Models;

namespace burgershack
{
    class Program
    {
        static void Main(string[] args)
        {

            // List<ILight> lightSources = new List<ILight>(){
            // new Mushroom(),
            // new ScentedCandle(),
            // new WaxCandle()
            // };


            // foreach (var light in lightSources)
            // {
            //     light.Illuminate();
            // }

            Console.Clear();
            BurgershackController bc = new BurgershackController();
            bc.Run();
        }

    }

}
