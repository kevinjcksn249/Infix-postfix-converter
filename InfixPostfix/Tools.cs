//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Tokenizer
//	File Name:		Tools.cs
//	Description:	A collection of useful static methods
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Kevin Jackson, jacksonka1@goldmail.etsu.edu, Department of Computing, East Tennessee State University
//	Created:		September 14, 2015
//	Copyright:		Kevin Jackson, 2015
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tokenizer
{
    public static class Tools
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
    }
}
