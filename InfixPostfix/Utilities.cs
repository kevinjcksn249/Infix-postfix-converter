//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Infix - Postfix
//	File Name:		Utilities.cs
//	Description:	Set of multi-purpose string manipulation tools
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

namespace InfixPostfix
{
    static class Utilities
    {
        /// <summary>
        /// Tokenizes the specified line.
        /// </summary>
        /// <param name="line">The line.</param>
        /// <param name="delim">List of delimiters in the form of a string.</param>
        /// <returns><see cref="List{String}"/>: the "words" in the line</returns>
        public static List<String> Tokenize(string line, string delims)
        {
            //Return value
            List<string> tokens = new List<string>();

            //Find first token
            char[] delimsArray = delims.ToArray();
            line = line.Trim();
            int delimIndex = line.IndexOfAny(delimsArray);
            string token;

            if (delimIndex == 0)
            {
                token = line.Substring(0, 1);
                line = line.Remove(0, 1);
            }

            else if (delimIndex == -1)
            {
                token = line.Substring(0, line.Length);
                token.Trim(@" \t".ToCharArray());
                line = line.Remove(0, line.Length);
                line = line.Trim(" \t".ToCharArray());
            }

            else
            {
                token = line.Substring(0, delimIndex);
                token.Trim(@" \t".ToCharArray());
                line = line.Remove(0, delimIndex);
                line = line.Trim(" \t".ToCharArray());
            }

            tokens.Add(token);

            bool done = String.IsNullOrEmpty(line);

            //If there is any more string left, break off remaining tokens recursively
            if (done == false)
                tokens.AddRange(Tokenize(line, delims));

            return tokens;
        }

        public static bool ContainsAChar(List<string> l, char[] c)
        {
            bool contains = false;

            return contains;
        }
    }
}
