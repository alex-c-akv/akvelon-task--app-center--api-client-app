/* 
 * App Center Client
 *
 * Microsoft Visual Studio App Center API
 *
 * OpenAPI spec version: v0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = AppCenterApiClientLib.Client.SwaggerDateConverter;

namespace AppCenterApiClientLib.Model
{
    /// <summary>
    /// V01appsownerNameappNamedistributionStoresIntuneDetails1SecretJson
    /// </summary>
    [DataContract]
        public partial class V01appsownerNameappNamedistributionStoresIntuneDetails1SecretJson :  IEquatable<V01appsownerNameappNamedistributionStoresIntuneDetails1SecretJson>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V01appsownerNameappNamedistributionStoresIntuneDetails1SecretJson" /> class.
        /// </summary>
        /// <param name="idToken">the id token of user.</param>
        /// <param name="refreshToken">the refresh token for user.</param>
        /// <param name="refreshTokenExpiry">the expiry of refresh token.</param>
        public V01appsownerNameappNamedistributionStoresIntuneDetails1SecretJson(string idToken = default(string), string refreshToken = default(string), string refreshTokenExpiry = default(string))
        {
            this.IdToken = idToken;
            this.RefreshToken = refreshToken;
            this.RefreshTokenExpiry = refreshTokenExpiry;
        }
        
        /// <summary>
        /// the id token of user
        /// </summary>
        /// <value>the id token of user</value>
        [DataMember(Name="id_token", EmitDefaultValue=false)]
        public string IdToken { get; set; }

        /// <summary>
        /// the refresh token for user
        /// </summary>
        /// <value>the refresh token for user</value>
        [DataMember(Name="refresh_token", EmitDefaultValue=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// the expiry of refresh token
        /// </summary>
        /// <value>the expiry of refresh token</value>
        [DataMember(Name="refresh_token_expiry", EmitDefaultValue=false)]
        public string RefreshTokenExpiry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V01appsownerNameappNamedistributionStoresIntuneDetails1SecretJson {\n");
            sb.Append("  IdToken: ").Append(IdToken).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  RefreshTokenExpiry: ").Append(RefreshTokenExpiry).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as V01appsownerNameappNamedistributionStoresIntuneDetails1SecretJson);
        }

        /// <summary>
        /// Returns true if V01appsownerNameappNamedistributionStoresIntuneDetails1SecretJson instances are equal
        /// </summary>
        /// <param name="input">Instance of V01appsownerNameappNamedistributionStoresIntuneDetails1SecretJson to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V01appsownerNameappNamedistributionStoresIntuneDetails1SecretJson input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdToken == input.IdToken ||
                    (this.IdToken != null &&
                    this.IdToken.Equals(input.IdToken))
                ) && 
                (
                    this.RefreshToken == input.RefreshToken ||
                    (this.RefreshToken != null &&
                    this.RefreshToken.Equals(input.RefreshToken))
                ) && 
                (
                    this.RefreshTokenExpiry == input.RefreshTokenExpiry ||
                    (this.RefreshTokenExpiry != null &&
                    this.RefreshTokenExpiry.Equals(input.RefreshTokenExpiry))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.IdToken != null)
                    hashCode = hashCode * 59 + this.IdToken.GetHashCode();
                if (this.RefreshToken != null)
                    hashCode = hashCode * 59 + this.RefreshToken.GetHashCode();
                if (this.RefreshTokenExpiry != null)
                    hashCode = hashCode * 59 + this.RefreshTokenExpiry.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}