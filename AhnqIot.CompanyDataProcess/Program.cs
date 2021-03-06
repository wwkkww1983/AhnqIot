﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AhnqIot.Bussiness.Core;
using AhnqIot.CameraStationDataProcess;
using AhnqIot.Infrastructure.DI;
using Autofac;
using NewLife.Log;

namespace AhnqIot.CompanyDataProcess
{
    class Program
    {
        private static void Main(string[] args)
        {
            XTrace.UseConsole();

            var builder = new ContainerBuilder();
            AhnqIotContainer.Builder = builder;
            //注册
            //BootStraper.Start();
            BussinessBootStraper.Start();
            //使用
            //var container = AhnqIotContainer.Container;


            CompanyCameraDeviceJobService.ServiceMain();
        }
    }
}
