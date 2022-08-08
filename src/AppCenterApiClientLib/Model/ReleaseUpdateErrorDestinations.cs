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
    /// ReleaseUpdateErrorDestinations
    /// </summary>
    [DataContract]
        public partial class ReleaseUpdateErrorDestinations :  IEquatable<ReleaseUpdateErrorDestinations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseUpdateErrorDestinations" /> class.
        /// </summary>
        /// <param name="code">Error Codes:&lt;br&gt; &lt;b&gt;invalid_store_secrets&lt;/b&gt;: While distributing to store, secrets provided for store are not valid.&lt;br&gt; &lt;b&gt;store_release_bad_request&lt;/b&gt;: Proper package release details for the store is not provided.&lt;br&gt; &lt;b&gt;store_release_unauthorized&lt;/b&gt;: User is not authorized to publish to store due to invalid developer credentials.&lt;br&gt; &lt;b&gt;store_release_forbidden&lt;/b&gt;: Publish to store is forbidden due to conflicts/errors in the release version and already existing version in the store.&lt;br&gt; &lt;b&gt;store_release_promotion&lt;/b&gt;: Release already distributed, promoting a release is not supported.&lt;br&gt; &lt;b&gt;store_track_deactivated&lt;/b&gt;: One or more tracks would be deactivated with this release. This is not supported yet.&lt;br&gt; &lt;b&gt;store_release_not_found&lt;/b&gt;: App with the given package name is not found in the store.&lt;br&gt; &lt;b&gt;store_release_not_available&lt;/b&gt;: The release is not available.&lt;br&gt; &lt;b&gt;internal_server_error&lt;/b&gt;: Failed to distribute to a destination due to an internal server error. .</param>
        /// <param name="message">message.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        public ReleaseUpdateErrorDestinations(string code = default(string), string message = default(string), string id = default(string), string name = default(string))
        {
            this.Code = code;
            this.Message = message;
            this.Id = id;
            this.Name = name;
        }
        
        /// <summary>
        /// Error Codes:&lt;br&gt; &lt;b&gt;invalid_store_secrets&lt;/b&gt;: While distributing to store, secrets provided for store are not valid.&lt;br&gt; &lt;b&gt;store_release_bad_request&lt;/b&gt;: Proper package release details for the store is not provided.&lt;br&gt; &lt;b&gt;store_release_unauthorized&lt;/b&gt;: User is not authorized to publish to store due to invalid developer credentials.&lt;br&gt; &lt;b&gt;store_release_forbidden&lt;/b&gt;: Publish to store is forbidden due to conflicts/errors in the release version and already existing version in the store.&lt;br&gt; &lt;b&gt;store_release_promotion&lt;/b&gt;: Release already distributed, promoting a release is not supported.&lt;br&gt; &lt;b&gt;store_track_deactivated&lt;/b&gt;: One or more tracks would be deactivated with this release. This is not supported yet.&lt;br&gt; &lt;b&gt;store_release_not_found&lt;/b&gt;: App with the given package name is not found in the store.&lt;br&gt; &lt;b&gt;store_release_not_available&lt;/b&gt;: The release is not available.&lt;br&gt; &lt;b&gt;internal_server_error&lt;/b&gt;: Failed to distribute to a destination due to an internal server error. 
        /// </summary>
        /// <value>Error Codes:&lt;br&gt; &lt;b&gt;invalid_store_secrets&lt;/b&gt;: While distributing to store, secrets provided for store are not valid.&lt;br&gt; &lt;b&gt;store_release_bad_request&lt;/b&gt;: Proper package release details for the store is not provided.&lt;br&gt; &lt;b&gt;store_release_unauthorized&lt;/b&gt;: User is not authorized to publish to store due to invalid developer credentials.&lt;br&gt; &lt;b&gt;store_release_forbidden&lt;/b&gt;: Publish to store is forbidden due to conflicts/errors in the release version and already existing version in the store.&lt;br&gt; &lt;b&gt;store_release_promotion&lt;/b&gt;: Release already distributed, promoting a release is not supported.&lt;br&gt; &lt;b&gt;store_track_deactivated&lt;/b&gt;: One or more tracks would be deactivated with this release. This is not supported yet.&lt;br&gt; &lt;b&gt;store_release_not_found&lt;/b&gt;: App with the given package name is not found in the store.&lt;br&gt; &lt;b&gt;store_release_not_available&lt;/b&gt;: The release is not available.&lt;br&gt; &lt;b&gt;internal_server_error&lt;/b&gt;: Failed to distribute to a destination due to an internal server error. </value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReleaseUpdateErrorDestinations {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as ReleaseUpdateErrorDestinations);
        }

        /// <summary>
        /// Returns true if ReleaseUpdateErrorDestinations instances are equal
        /// </summary>
        /// <param name="input">Instance of ReleaseUpdateErrorDestinations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReleaseUpdateErrorDestinations input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
