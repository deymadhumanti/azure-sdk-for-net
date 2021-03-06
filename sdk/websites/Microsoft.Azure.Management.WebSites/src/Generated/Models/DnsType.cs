// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DnsType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DnsType
    {
        [EnumMember(Value = "AzureDns")]
        AzureDns,
        [EnumMember(Value = "DefaultDomainRegistrarDns")]
        DefaultDomainRegistrarDns
    }
    internal static class DnsTypeEnumExtension
    {
        internal static string ToSerializedValue(this DnsType? value)
        {
            return value == null ? null : ((DnsType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DnsType value)
        {
            switch( value )
            {
                case DnsType.AzureDns:
                    return "AzureDns";
                case DnsType.DefaultDomainRegistrarDns:
                    return "DefaultDomainRegistrarDns";
            }
            return null;
        }

        internal static DnsType? ParseDnsType(this string value)
        {
            switch( value )
            {
                case "AzureDns":
                    return DnsType.AzureDns;
                case "DefaultDomainRegistrarDns":
                    return DnsType.DefaultDomainRegistrarDns;
            }
            return null;
        }
    }
}
