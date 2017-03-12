//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Infix - Postfix
//	File Name:		PostFix.cs
//	Description:	Converts a given infix expression to postfix and stores the result
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
    /// <summary>
    /// Converts a given infix expression to postfix and stores the result
    /// </summary>
    class PostFix
    {
        public string InfixExpression { get; private set; }
        public string PostfixExpression { get; private set; }

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="PostFix"/> class.
        /// </summary>
        public PostFix()
        {
            InfixExpression = "A + B = C";
            PostfixExpression = Convert(InfixExpression);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostFix"/> class.
        /// </summary>
        /// <param name="input">Infix expression to convert to Postfix.</param>
        public PostFix(string input)
        {
            InfixExpression = input;
            PostfixExpression = Convert(InfixExpression);
        }
        #endregion

        #region Convert
        /// <summary>
        /// Converts the given infix expression to postfix
        /// </summary>
        /// <param name="inf">The infix expression.</param>
        /// <returns>A <see cref="string"/> containing the resulting postfix expression</returns>
        private string Convert(string inf)
        {
            Stack<char> operators = new Stack<char>();
            string res = "";
            string ops = "+-*/%=()";
            char[] opArray = ops.ToCharArray();
            List<string> opList = new List<string>(;
            List<string> tokens = Utilities.Tokenize(inf,ops);

            return res;
        }
        #endregion
    }
}
