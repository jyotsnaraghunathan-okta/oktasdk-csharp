using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using Newtonsoft.Json.Converters;

namespace Okta.Core.Models
{
    /// <summary>
    /// The types of tokens available when requesting a <see cref="Session"/>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TokenAttribute
    {
        /// <summary>
        /// Manually set a cookie
        /// </summary>
        [EnumMember(Value = "cookieToken")]
        CookieToken,

        /// <summary>
        /// Set a cookie when the user clicks a URL
        /// </summary>
        [EnumMember(Value = "cookieTokenUrl")]
        CookieTokenUrl
    }
}