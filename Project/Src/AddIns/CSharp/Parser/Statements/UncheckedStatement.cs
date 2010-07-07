//-----------------------------------------------------------------------
// <copyright file="UncheckedStatement.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// <license>
//   This source code is subject to terms and conditions of the Microsoft 
//   Public License. A copy of the license can be found in the License.html 
//   file at the root of this distribution. If you cannot locate the  
//   Microsoft Public License, please send an email to dlr@microsoft.com. 
//   By using this source code in any fashion, you are agreeing to be bound 
//   by the terms of the Microsoft Public License. You must not remove this 
//   notice, or any other, from this software.
// </license>
//-----------------------------------------------------------------------
namespace Microsoft.StyleCop.CSharp
{
    using System;

    /// <summary>
    /// A unchecked-statement.
    /// </summary>
    /// <subcategory>statement</subcategory>
    public sealed class UncheckedStatement : Statement
    {
        #region Private Fields

        /// <summary>
        /// The statement embedded within this unchecked statement, if any.
        /// </summary>
        private BlockStatement embeddedStatement;

        #endregion Private Fields

        #region Internal Constructors

        /// <summary>
        /// Initializes a new instance of the UncheckedStatement class.
        /// </summary>
        /// <param name="proxy">Proxy object for the statement.</param>
        /// <param name="embeddedStatement">The block statement embedded within this unchecked statement, if any.</param>
        internal UncheckedStatement(CodeUnitProxy proxy, BlockStatement embeddedStatement)
            : base(proxy, StatementType.Unchecked)
        {
            Param.AssertNotNull(proxy, "proxy");
            Param.AssertNotNull(embeddedStatement, "embeddedStatement");

            this.embeddedStatement = embeddedStatement;
        }

        #endregion Internal Constructors

        #region Public Properties

        /// <summary>
        /// Gets the block statement embedded within this unchecked statement, if any.
        /// </summary>
        public BlockStatement EmbeddedStatement
        {
            get
            {
                return this.embeddedStatement;
            }
        }

        #endregion Public Properties
    }
}
