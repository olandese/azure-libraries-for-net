// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The impact of an operation, both in absolute and relative terms.
    /// </summary>
    public partial class OperationImpact
    {
        /// <summary>
        /// Initializes a new instance of the OperationImpact class.
        /// </summary>
        public OperationImpact()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationImpact class.
        /// </summary>
        /// <param name="name">The name of the impact dimension.</param>
        /// <param name="unit">The unit in which estimated impact to dimension
        /// is measured.</param>
        /// <param name="changeValueAbsolute">The absolute impact to
        /// dimension.</param>
        /// <param name="changeValueRelative">The relative impact to dimension
        /// (null if not applicable)</param>
        public OperationImpact(string name = default(string), string unit = default(string), double? changeValueAbsolute = default(double?), double? changeValueRelative = default(double?))
        {
            Name = name;
            Unit = unit;
            ChangeValueAbsolute = changeValueAbsolute;
            ChangeValueRelative = changeValueRelative;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of the impact dimension.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the unit in which estimated impact to dimension is measured.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; private set; }

        /// <summary>
        /// Gets the absolute impact to dimension.
        /// </summary>
        [JsonProperty(PropertyName = "changeValueAbsolute")]
        public double? ChangeValueAbsolute { get; private set; }

        /// <summary>
        /// Gets the relative impact to dimension (null if not applicable)
        /// </summary>
        [JsonProperty(PropertyName = "changeValueRelative")]
        public double? ChangeValueRelative { get; private set; }

    }
}
