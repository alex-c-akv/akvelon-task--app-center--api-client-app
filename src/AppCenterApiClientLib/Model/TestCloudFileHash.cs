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
    /// Hash, type, path and byte range of a file that is required in test run
    /// </summary>
    [DataContract]
        public partial class TestCloudFileHash :  IEquatable<TestCloudFileHash>, IValidatableObject
    {
        /// <summary>
        /// Type of the file
        /// </summary>
        /// <value>Type of the file</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum FileTypeEnum
        {
            /// <summary>
            /// Enum DsymFile for value: dsym-file
            /// </summary>
            [EnumMember(Value = "dsym-file")]
            DsymFile = 1,
            /// <summary>
            /// Enum AppFile for value: app-file
            /// </summary>
            [EnumMember(Value = "app-file")]
            AppFile = 2,
            /// <summary>
            /// Enum TestFile for value: test-file
            /// </summary>
            [EnumMember(Value = "test-file")]
            TestFile = 3        }
        /// <summary>
        /// Type of the file
        /// </summary>
        /// <value>Type of the file</value>
        [DataMember(Name="fileType", EmitDefaultValue=false)]
        public FileTypeEnum FileType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestCloudFileHash" /> class.
        /// </summary>
        /// <param name="fileType">Type of the file (required).</param>
        /// <param name="checksum">SHA256 hash of the file (required).</param>
        /// <param name="relativePath">Relative path of the file (required).</param>
        public TestCloudFileHash(FileTypeEnum fileType = default(FileTypeEnum), string checksum = default(string), string relativePath = default(string))
        {
            // to ensure "fileType" is required (not null)
            if (fileType == null)
            {
                throw new InvalidDataException("fileType is a required property for TestCloudFileHash and cannot be null");
            }
            else
            {
                this.FileType = fileType;
            }
            // to ensure "checksum" is required (not null)
            if (checksum == null)
            {
                throw new InvalidDataException("checksum is a required property for TestCloudFileHash and cannot be null");
            }
            else
            {
                this.Checksum = checksum;
            }
            // to ensure "relativePath" is required (not null)
            if (relativePath == null)
            {
                throw new InvalidDataException("relativePath is a required property for TestCloudFileHash and cannot be null");
            }
            else
            {
                this.RelativePath = relativePath;
            }
        }
        

        /// <summary>
        /// SHA256 hash of the file
        /// </summary>
        /// <value>SHA256 hash of the file</value>
        [DataMember(Name="checksum", EmitDefaultValue=false)]
        public string Checksum { get; set; }

        /// <summary>
        /// Relative path of the file
        /// </summary>
        /// <value>Relative path of the file</value>
        [DataMember(Name="relativePath", EmitDefaultValue=false)]
        public string RelativePath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestCloudFileHash {\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  Checksum: ").Append(Checksum).Append("\n");
            sb.Append("  RelativePath: ").Append(RelativePath).Append("\n");
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
            return this.Equals(input as TestCloudFileHash);
        }

        /// <summary>
        /// Returns true if TestCloudFileHash instances are equal
        /// </summary>
        /// <param name="input">Instance of TestCloudFileHash to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestCloudFileHash input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileType == input.FileType ||
                    (this.FileType != null &&
                    this.FileType.Equals(input.FileType))
                ) && 
                (
                    this.Checksum == input.Checksum ||
                    (this.Checksum != null &&
                    this.Checksum.Equals(input.Checksum))
                ) && 
                (
                    this.RelativePath == input.RelativePath ||
                    (this.RelativePath != null &&
                    this.RelativePath.Equals(input.RelativePath))
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
                if (this.FileType != null)
                    hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.Checksum != null)
                    hashCode = hashCode * 59 + this.Checksum.GetHashCode();
                if (this.RelativePath != null)
                    hashCode = hashCode * 59 + this.RelativePath.GetHashCode();
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
