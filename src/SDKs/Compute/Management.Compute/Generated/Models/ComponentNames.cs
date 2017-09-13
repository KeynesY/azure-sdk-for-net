// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ComponentNames.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ComponentNames
    {
        [EnumMember(Value = "Microsoft-Windows-Shell-Setup")]
        MicrosoftWindowsShellSetup
    }
    internal static class ComponentNamesEnumExtension
    {
        internal static string ToSerializedValue(this ComponentNames? value)  =>
            value == null ? null : ((ComponentNames)value).ToSerializedValue();

        internal static string ToSerializedValue(this ComponentNames value)
        {
            switch( value )
            {
                case ComponentNames.MicrosoftWindowsShellSetup:
                    return "Microsoft-Windows-Shell-Setup";
            }
            return null;
        }

        internal static ComponentNames? ParseComponentNames(this string value)
        {
            switch( value )
            {
                case "Microsoft-Windows-Shell-Setup":
                    return ComponentNames.MicrosoftWindowsShellSetup;
            }
            return null;
        }
    }
}