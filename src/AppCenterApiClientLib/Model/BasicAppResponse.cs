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
    /// BasicAppResponse
    /// </summary>
    [DataContract]
        public partial class BasicAppResponse :  IEquatable<BasicAppResponse>, IValidatableObject
    {
        /// <summary>
        /// The OS the app will be running on
        /// </summary>
        /// <value>The OS the app will be running on</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum OsEnum
        {
            /// <summary>
            /// Enum Android for value: Android
            /// </summary>
            [EnumMember(Value = "Android")]
            Android = 1,
            /// <summary>
            /// Enum IOS for value: iOS
            /// </summary>
            [EnumMember(Value = "iOS")]
            IOS = 2,
            /// <summary>
            /// Enum MacOS for value: macOS
            /// </summary>
            [EnumMember(Value = "macOS")]
            MacOS = 3,
            /// <summary>
            /// Enum Tizen for value: Tizen
            /// </summary>
            [EnumMember(Value = "Tizen")]
            Tizen = 4,
            /// <summary>
            /// Enum TvOS for value: tvOS
            /// </summary>
            [EnumMember(Value = "tvOS")]
            TvOS = 5,
            /// <summary>
            /// Enum Windows for value: Windows
            /// </summary>
            [EnumMember(Value = "Windows")]
            Windows = 6,
            /// <summary>
            /// Enum Linux for value: Linux
            /// </summary>
            [EnumMember(Value = "Linux")]
            Linux = 7,
            /// <summary>
            /// Enum Custom for value: Custom
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom = 8        }
        /// <summary>
        /// The OS the app will be running on
        /// </summary>
        /// <value>The OS the app will be running on</value>
        [DataMember(Name="os", EmitDefaultValue=false)]
        public OsEnum Os { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BasicAppResponse" /> class.
        /// </summary>
        /// <param name="id">The unique ID (UUID) of the app (required).</param>
        /// <param name="description">The description of the app.</param>
        /// <param name="displayName">The display name of the app (required).</param>
        /// <param name="releaseType">A one-word descriptive release-type value that starts with a capital letter but is otherwise lowercase.</param>
        /// <param name="iconUrl">The string representation of the URL pointing to the app&#x27;s icon.</param>
        /// <param name="iconSource">The string representation of the source of the app&#x27;s icon.</param>
        /// <param name="name">The name of the app used in URLs (required).</param>
        /// <param name="os">The OS the app will be running on (required).</param>
        /// <param name="owner">owner (required).</param>
        public BasicAppResponse(Guid? id = default(Guid?), string description = default(string), string displayName = default(string), string releaseType = default(string), string iconUrl = default(string), string iconSource = default(string), string name = default(string), OsEnum os = default(OsEnum), AppInvitationDetailResponseDistributionGroupOwner owner = default(AppInvitationDetailResponseDistributionGroupOwner))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for BasicAppResponse and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for BasicAppResponse and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for BasicAppResponse and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "os" is required (not null)
            if (os == null)
            {
                throw new InvalidDataException("os is a required property for BasicAppResponse and cannot be null");
            }
            else
            {
                this.Os = os;
            }
            // to ensure "owner" is required (not null)
            if (owner == null)
            {
                throw new InvalidDataException("owner is a required property for BasicAppResponse and cannot be null");
            }
            else
            {
                this.Owner = owner;
            }
            this.Description = description;
            this.ReleaseType = releaseType;
            this.IconUrl = iconUrl;
            this.IconSource = iconSource;
        }
        
        /// <summary>
        /// The unique ID (UUID) of the app
        /// </summary>
        /// <value>The unique ID (UUID) of the app</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// The description of the app
        /// </summary>
        /// <value>The description of the app</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The display name of the app
        /// </summary>
        /// <value>The display name of the app</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// A one-word descriptive release-type value that starts with a capital letter but is otherwise lowercase
        /// </summary>
        /// <value>A one-word descriptive release-type value that starts with a capital letter but is otherwise lowercase</value>
        [DataMember(Name="release_type", EmitDefaultValue=false)]
        public string ReleaseType { get; set; }

        /// <summary>
        /// The string representation of the URL pointing to the app&#x27;s icon
        /// </summary>
        /// <value>The string representation of the URL pointing to the app&#x27;s icon</value>
        [DataMember(Name="icon_url", EmitDefaultValue=false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// The string representation of the source of the app&#x27;s icon
        /// </summary>
        /// <value>The string representation of the source of the app&#x27;s icon</value>
        [DataMember(Name="icon_source", EmitDefaultValue=false)]
        public string IconSource { get; set; }

        /// <summary>
        /// The name of the app used in URLs
        /// </summary>
        /// <value>The name of the app used in URLs</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public AppInvitationDetailResponseDistributionGroupOwner Owner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BasicAppResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  ReleaseType: ").Append(ReleaseType).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  IconSource: ").Append(IconSource).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Os: ").Append(Os).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
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
            return this.Equals(input as BasicAppResponse);
        }

        /// <summary>
        /// Returns true if BasicAppResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BasicAppResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BasicAppResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.ReleaseType == input.ReleaseType ||
                    (this.ReleaseType != null &&
                    this.ReleaseType.Equals(input.ReleaseType))
                ) && 
                (
                    this.IconUrl == input.IconUrl ||
                    (this.IconUrl != null &&
                    this.IconUrl.Equals(input.IconUrl))
                ) && 
                (
                    this.IconSource == input.IconSource ||
                    (this.IconSource != null &&
                    this.IconSource.Equals(input.IconSource))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Os == input.Os ||
                    (this.Os != null &&
                    this.Os.Equals(input.Os))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.ReleaseType != null)
                    hashCode = hashCode * 59 + this.ReleaseType.GetHashCode();
                if (this.IconUrl != null)
                    hashCode = hashCode * 59 + this.IconUrl.GetHashCode();
                if (this.IconSource != null)
                    hashCode = hashCode * 59 + this.IconSource.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Os != null)
                    hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
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
