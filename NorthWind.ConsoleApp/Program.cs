﻿
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;

IUserActionWriter Writer = new DebugWriter();
 
AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Aplicacion comenzo");

ProductService Service = new ProductService(Writer);
Service.Add("Demo", "Azucar");