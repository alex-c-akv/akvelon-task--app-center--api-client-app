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
    /// A collection of projects for each type of toolset
    /// </summary>
    [DataContract]
        public partial class ToolsetProjects :  IEquatable<ToolsetProjects>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsetProjects" /> class.
        /// </summary>
        /// <param name="commit">The commit hash of the analyzed commit.</param>
        /// <param name="xcode">xcode.</param>
        /// <param name="javascript">javascript.</param>
        /// <param name="xamarin">xamarin.</param>
        /// <param name="android">android.</param>
        /// <param name="buildscripts">A collection of detected pre/post buildscripts for current platform toolset.</param>
        /// <param name="uwp">uwp.</param>
        /// <param name="testcloud">testcloud.</param>
        public ToolsetProjects(string commit = default(string), ToolsetProjectsXcode xcode = default(ToolsetProjectsXcode), ToolsetProjectsJavascript javascript = default(ToolsetProjectsJavascript), ToolsetProjectsXamarin xamarin = default(ToolsetProjectsXamarin), ToolsetProjectsAndroid android = default(ToolsetProjectsAndroid), Object buildscripts = default(Object), ToolsetProjectsUwp uwp = default(ToolsetProjectsUwp), ToolsetProjectsTestcloud testcloud = default(ToolsetProjectsTestcloud))
        {
            this.Commit = commit;
            this.Xcode = xcode;
            this.Javascript = javascript;
            this.Xamarin = xamarin;
            this.Android = android;
            this.Buildscripts = buildscripts;
            this.Uwp = uwp;
            this.Testcloud = testcloud;
        }
        
        /// <summary>
        /// The commit hash of the analyzed commit
        /// </summary>
        /// <value>The commit hash of the analyzed commit</value>
        [DataMember(Name="commit", EmitDefaultValue=false)]
        public string Commit { get; set; }

        /// <summary>
        /// Gets or Sets Xcode
        /// </summary>
        [DataMember(Name="xcode", EmitDefaultValue=false)]
        public ToolsetProjectsXcode Xcode { get; set; }

        /// <summary>
        /// Gets or Sets Javascript
        /// </summary>
        [DataMember(Name="javascript", EmitDefaultValue=false)]
        public ToolsetProjectsJavascript Javascript { get; set; }

        /// <summary>
        /// Gets or Sets Xamarin
        /// </summary>
        [DataMember(Name="xamarin", EmitDefaultValue=false)]
        public ToolsetProjectsXamarin Xamarin { get; set; }

        /// <summary>
        /// Gets or Sets Android
        /// </summary>
        [DataMember(Name="android", EmitDefaultValue=false)]
        public ToolsetProjectsAndroid Android { get; set; }

        /// <summary>
        /// A collection of detected pre/post buildscripts for current platform toolset
        /// </summary>
        /// <value>A collection of detected pre/post buildscripts for current platform toolset</value>
        [DataMember(Name="buildscripts", EmitDefaultValue=false)]
        public Object Buildscripts { get; set; }

        /// <summary>
        /// Gets or Sets Uwp
        /// </summary>
        [DataMember(Name="uwp", EmitDefaultValue=false)]
        public ToolsetProjectsUwp Uwp { get; set; }

        /// <summary>
        /// Gets or Sets Testcloud
        /// </summary>
        [DataMember(Name="testcloud", EmitDefaultValue=false)]
        public ToolsetProjectsTestcloud Testcloud { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ToolsetProjects {\n");
            sb.Append("  Commit: ").Append(Commit).Append("\n");
            sb.Append("  Xcode: ").Append(Xcode).Append("\n");
            sb.Append("  Javascript: ").Append(Javascript).Append("\n");
            sb.Append("  Xamarin: ").Append(Xamarin).Append("\n");
            sb.Append("  Android: ").Append(Android).Append("\n");
            sb.Append("  Buildscripts: ").Append(Buildscripts).Append("\n");
            sb.Append("  Uwp: ").Append(Uwp).Append("\n");
            sb.Append("  Testcloud: ").Append(Testcloud).Append("\n");
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
            return this.Equals(input as ToolsetProjects);
        }

        /// <summary>
        /// Returns true if ToolsetProjects instances are equal
        /// </summary>
        /// <param name="input">Instance of ToolsetProjects to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ToolsetProjects input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Commit == input.Commit ||
                    (this.Commit != null &&
                    this.Commit.Equals(input.Commit))
                ) && 
                (
                    this.Xcode == input.Xcode ||
                    (this.Xcode != null &&
                    this.Xcode.Equals(input.Xcode))
                ) && 
                (
                    this.Javascript == input.Javascript ||
                    (this.Javascript != null &&
                    this.Javascript.Equals(input.Javascript))
                ) && 
                (
                    this.Xamarin == input.Xamarin ||
                    (this.Xamarin != null &&
                    this.Xamarin.Equals(input.Xamarin))
                ) && 
                (
                    this.Android == input.Android ||
                    (this.Android != null &&
                    this.Android.Equals(input.Android))
                ) && 
                (
                    this.Buildscripts == input.Buildscripts ||
                    (this.Buildscripts != null &&
                    this.Buildscripts.Equals(input.Buildscripts))
                ) && 
                (
                    this.Uwp == input.Uwp ||
                    (this.Uwp != null &&
                    this.Uwp.Equals(input.Uwp))
                ) && 
                (
                    this.Testcloud == input.Testcloud ||
                    (this.Testcloud != null &&
                    this.Testcloud.Equals(input.Testcloud))
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
                if (this.Commit != null)
                    hashCode = hashCode * 59 + this.Commit.GetHashCode();
                if (this.Xcode != null)
                    hashCode = hashCode * 59 + this.Xcode.GetHashCode();
                if (this.Javascript != null)
                    hashCode = hashCode * 59 + this.Javascript.GetHashCode();
                if (this.Xamarin != null)
                    hashCode = hashCode * 59 + this.Xamarin.GetHashCode();
                if (this.Android != null)
                    hashCode = hashCode * 59 + this.Android.GetHashCode();
                if (this.Buildscripts != null)
                    hashCode = hashCode * 59 + this.Buildscripts.GetHashCode();
                if (this.Uwp != null)
                    hashCode = hashCode * 59 + this.Uwp.GetHashCode();
                if (this.Testcloud != null)
                    hashCode = hashCode * 59 + this.Testcloud.GetHashCode();
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
