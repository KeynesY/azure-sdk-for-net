// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Store;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ExpiryOptionType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExpiryOptionType
    {
        [EnumMember(Value = "NeverExpire")]
        NeverExpire,
        [EnumMember(Value = "RelativeToNow")]
        RelativeToNow,
        [EnumMember(Value = "RelativeToCreationDate")]
        RelativeToCreationDate,
        [EnumMember(Value = "Absolute")]
        Absolute
    }
    internal static class ExpiryOptionTypeEnumExtension
    {
        internal static string ToSerializedValue(this ExpiryOptionType? value)  =>
            value == null ? null : ((ExpiryOptionType)value).ToSerializedValue();

        internal static string ToSerializedValue(this ExpiryOptionType value)
        {
            switch( value )
            {
                case ExpiryOptionType.NeverExpire:
                    return "NeverExpire";
                case ExpiryOptionType.RelativeToNow:
                    return "RelativeToNow";
                case ExpiryOptionType.RelativeToCreationDate:
                    return "RelativeToCreationDate";
                case ExpiryOptionType.Absolute:
                    return "Absolute";
            }
            return null;
        }

        internal static ExpiryOptionType? ParseExpiryOptionType(this string value)
        {
            switch( value )
            {
                case "NeverExpire":
                    return ExpiryOptionType.NeverExpire;
                case "RelativeToNow":
                    return ExpiryOptionType.RelativeToNow;
                case "RelativeToCreationDate":
                    return ExpiryOptionType.RelativeToCreationDate;
                case "Absolute":
                    return ExpiryOptionType.Absolute;
            }
            return null;
        }
    }
}