﻿// Copyright (c) 2012-2020 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

using Dicom.Log;
using System;

namespace Worklist_SCP
{

   public class Program
   {

      protected Program()
      {
      }


      static void Main(string[] args)
      {
         // Initialize log manager.
         LogManager.SetImplementation(ConsoleLogManager.Instance);

            int tmp = 0;
         var port = args != null && args.Length > 0 && int.TryParse(args[0], out tmp) ? tmp : 8005;

         Console.WriteLine($"Starting QR SCP server with AET: QRSCP on port {port}");

         WorklistServer.Start(port, "QRSCP");

         Console.WriteLine("Press any key to stop the service");

         Console.Read();

         Console.WriteLine("Stopping QR service");

         WorklistServer.Stop();
      }

   }
}
