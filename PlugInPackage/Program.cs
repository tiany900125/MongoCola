﻿using System;
using System.Windows.Forms;
using PlugInPackage.ImportAccessDB;
using MongoDB.Driver;

namespace PlugInPackage
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            //这句话如果写到后面去的话，在没有Config文件的时候，服务器树形列表显示不正确
            Application.EnableVisualStyles();
            //初始化
            var frmMain = new FrmSelectTable();
            var client = new MongoClient("mongodb://localhost:28030");
            var server = client.GetServer();
            frmMain.mServer = server;
            Application.Run(frmMain);
        }
    }
}