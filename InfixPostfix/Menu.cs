//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Infix-Postfix
//	File Name:		Menu.cs
//	Description:	Tools for quickly generating console menus and prompts
//	Author:			Kevin Jackson, kevinjcksn249@gmail.com, 
//	Created:		January 13, 2017
//	Copyright:		Kevin Jackson, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenus
{
    class Menu
    {
        #region Properties
        public string Title { get; private set; }
        public int Padding { get; private set; }
        public char Delim { get; private set; }
        public List<string> Choices { get; private set; }
        public string Prompt { get; private set; }
        public int NumChoices { get; private set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Menu"/> class.
        /// </summary>
        /// <param name="p">Number spaces from the left the menu will appear.</param>
        /// <param name="pr">Prompt requesting user input.</param>
        /// <param name="t">Menu title.</param>
        /// <param name="d">Delimiter displayed before every menu choice.</param>
        public Menu(int? p = 0, string pr = "Press any key to continue: ", string t = "Sample Menu", char? d = ':')
        {
            Title = t;
            Prompt = pr;
            Padding = (int)p;
            Delim = (char)d;
            Choices = new List<string>();
            NumChoices = 0;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds a choice to the menu.
        /// </summary>
        /// <param name="c">The c.</param>
        public void AddChoice(string c)
        {
            NumChoices++;
            Choices.Add(NumChoices.ToString() + Delim + " " + c);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            string msg = "\n";
            msg = Pad(msg);
            msg += Title + "\n";
            foreach (string choice in Choices)
            {
                msg = Pad(msg);
                msg += choice + "\n";
            }
            msg += "\n";
            msg = Pad(msg);
            msg += Prompt;
            return msg;
        }

        /// <summary>
        /// Pads the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        /// <returns></returns>
        private string Pad(string msg)
        {
            for (int i = 0; i < Padding; i++)
                msg += " ";
            return msg;
        }
        #endregion
    }
}
