//-----------------------------------------------------------------------
// <copyright file="ICodeUnit.cs" company="Microsoft">
//   Copyright (c) Microsoft Corporation.
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
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Describes a namespace element.
    /// </summary>
    /// <subcategory>element</subcategory>
    [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", Justification = "The class describes a C# namespace")]
    public class Namespace : Element
    {
        #region Internal Constructors

        /// <summary>
        /// Initializes a new instance of the Namespace class.
        /// </summary>
        /// <param name="proxy">Proxy object for the namespace.</param>
        /// <param name="name">The name of the namespace.</param>
        /// <param name="attributes">The list of attributes attached to this element.</param>
        /// <param name="unsafeCode">Indicates whether the element resides within a block of unsafe code.</param>
        internal Namespace(CodeUnitProxy proxy, string name, ICollection<Attribute> attributes, bool unsafeCode)
            : base(proxy, ElementType.Namespace, name, attributes, unsafeCode)
        {
            Param.AssertNotNull(proxy, "proxy");
            Param.AssertValidString(name, "name");
            Param.Ignore(attributes, unsafeCode);

            this.AccessLevel = AccessModifierType.Public;
        }

        /// <summary>
        /// Initializes a new instance of the Namespace class.
        /// </summary>
        /// <param name="proxy">Proxy object for the namespace.</param>
        /// <param name="type">The element type.</param>
        /// <param name="name">The name of this element.</param>
        /// <param name="attributes">The list of attributes attached to this element.</param>
        /// <param name="unsafeCode">Indicates whether the element resides within a block of unsafe code.</param>
        internal Namespace(CodeUnitProxy proxy, ElementType type, string name, ICollection<Attribute> attributes, bool unsafeCode)
            : base(proxy, type, name, attributes, unsafeCode)
        {
            Param.Ignore(proxy, type, name, attributes, unsafeCode);
            this.AccessLevel = AccessModifierType.Public;
        }

        #endregion Internal Constructors

        #region Protected Override Properties

        /// <summary>
        /// Gets the collection of modifiers allowed on this element.
        /// </summary>
        protected override IEnumerable<string> AllowedModifiers
        {
            get
            {
                return new string[] { };
            }
        }

        #endregion Protected Override Properties
    }
}
