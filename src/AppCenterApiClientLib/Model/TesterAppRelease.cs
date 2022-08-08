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
    /// TesterAppRelease
    /// </summary>
    [DataContract]
        public partial class TesterAppRelease :  IEquatable<TesterAppRelease>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TesterAppRelease" /> class.
        /// </summary>
        /// <param name="size">The release&#x27;s size in bytes. (required).</param>
        /// <param name="installUrl">The href required to install a release on a mobile device. On iOS devices will be prefixed with &#x60;itms-services://?action&#x3D;download-manifest&amp;url&#x3D;&#x60;.</param>
        /// <param name="releaseNotes">The release&#x27;s release notes..</param>
        public TesterAppRelease(int? size = default(int?), string installUrl = default(string), string releaseNotes = default(string))
        {
            // to ensure "size" is required (not null)
            if (size == null)
            {
                throw new InvalidDataException("size is a required property for TesterAppRelease and cannot be null");
            }
            else
            {
                this.Size = size;
            }
            this.InstallUrl = installUrl;
            this.ReleaseNotes = releaseNotes;
        }
        
        /// <summary>
        /// The release&#x27;s size in bytes.
        /// </summary>
        /// <value>The release&#x27;s size in bytes.</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }

        /// <summary>
        /// The href required to install a release on a mobile device. On iOS devices will be prefixed with &#x60;itms-services://?action&#x3D;download-manifest&amp;url&#x3D;&#x60;
        /// </summary>
        /// <value>The href required to install a release on a mobile device. On iOS devices will be prefixed with &#x60;itms-services://?action&#x3D;download-manifest&amp;url&#x3D;&#x60;</value>
        [DataMember(Name="install_url", EmitDefaultValue=false)]
        public string InstallUrl { get; set; }

        /// <summary>
        /// The release&#x27;s release notes.
        /// </summary>
        /// <value>The release&#x27;s release notes.</value>
        [DataMember(Name="release_notes", EmitDefaultValue=false)]
        public string ReleaseNotes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TesterAppRelease {\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  InstallUrl: ").Append(InstallUrl).Append("\n");
            sb.Append("  ReleaseNotes: ").Append(ReleaseNotes).Append("\n");
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
            return this.Equals(input as TesterAppRelease);
        }

        /// <summary>
        /// Returns true if TesterAppRelease instances are equal
        /// </summary>
        /// <param name="input">Instance of TesterAppRelease to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TesterAppRelease input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.InstallUrl == input.InstallUrl ||
                    (this.InstallUrl != null &&
                    this.InstallUrl.Equals(input.InstallUrl))
                ) && 
                (
                    this.ReleaseNotes == input.ReleaseNotes ||
                    (this.ReleaseNotes != null &&
                    this.ReleaseNotes.Equals(input.ReleaseNotes))
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
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.InstallUrl != null)
                    hashCode = hashCode * 59 + this.InstallUrl.GetHashCode();
                if (this.ReleaseNotes != null)
                    hashCode = hashCode * 59 + this.ReleaseNotes.GetHashCode();
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
