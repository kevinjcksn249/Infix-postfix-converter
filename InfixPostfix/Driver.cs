//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Infix - Postfix
//	File Name:		Driver.cs
//	Description:	Tests the PostFix Class
//	Author:			Kevin Jackson, kevinjcksn249@gmail.com
//	Created:		March 12, 2017
//	Copyright:		Kevin Jackson, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using ConsoleMenus;

namespace InfixPostfix
{
    class Driver
    {
        static void Main(string[] args)
        {
            MainMenu();
            
        }

        static void MainMenu()
        {
            
            while (true)
            {
                Clear();
                Menu main = new Menu(p: 5, pr: "What do you wish to do?", t: "Infix - Postfix Converter", d: '.');
                main.AddChoice("Enter infix expression");
                main.AddChoice("Exit");
                Write(main);
                string userChoice = ReadKey().KeyChar.ToString();
                switch (userChoice)
                {
                    case "1":
                        DemoPostFix();
                        break;
                    case "2":
                        return;
                    default:
                        MainMenu();
                        break;
                }
            }
        }

        static void DemoPostFix()
        {
            Clear();
            Write("\n\n\tEnter an infix expression (Ex: A+B=C): ");
            string input = ReadLine();
            
            ReadKey();
        }
    }
}
