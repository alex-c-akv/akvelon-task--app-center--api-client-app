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
    /// frame belonging to the reason of the crash
    /// </summary>
    [DataContract]
        public partial class ReasonStackFrame :  IEquatable<ReasonStackFrame>, IValidatableObject
    {
        /// <summary>
        /// programming language of the frame
        /// </summary>
        /// <value>programming language of the frame</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum LanguageEnum
        {
            /// <summary>
            /// Enum JavaScript for value: JavaScript
            /// </summary>
            [EnumMember(Value = "JavaScript")]
            JavaScript = 1,
            /// <summary>
            /// Enum CSharp for value: CSharp
            /// </summary>
            [EnumMember(Value = "CSharp")]
            CSharp = 2,
            /// <summary>
            /// Enum ObjectiveC for value: Objective-C
            /// </summary>
            [EnumMember(Value = "Objective-C")]
            ObjectiveC = 3,
            /// <summary>
            /// Enum ObjectiveCpp for value: Objective-Cpp
            /// </summary>
            [EnumMember(Value = "Objective-Cpp")]
            ObjectiveCpp = 4,
            /// <summary>
            /// Enum Cpp for value: Cpp
            /// </summary>
            [EnumMember(Value = "Cpp")]
            Cpp = 5,
            /// <summary>
            /// Enum C for value: C
            /// </summary>
            [EnumMember(Value = "C")]
            C = 6,
            /// <summary>
            /// Enum Swift for value: Swift
            /// </summary>
            [EnumMember(Value = "Swift")]
            Swift = 7,
            /// <summary>
            /// Enum Java for value: Java
            /// </summary>
            [EnumMember(Value = "Java")]
            Java = 8,
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 9        }
        /// <summary>
        /// programming language of the frame
        /// </summary>
        /// <value>programming language of the frame</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public LanguageEnum? Language { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReasonStackFrame" /> class.
        /// </summary>
        /// <param name="className">name of the class.</param>
        /// <param name="method">name of the method.</param>
        /// <param name="classMethod">is a class method.</param>
        /// <param name="file">name of the file.</param>
        /// <param name="line">line number.</param>
        /// <param name="appCode">this line isn&#x27;t from any framework.</param>
        /// <param name="frameworkName">Name of the framework.</param>
        /// <param name="codeFormatted">Formatted frame string.</param>
        /// <param name="codeRaw">Unformatted Frame string.</param>
        /// <param name="language">programming language of the frame.</param>
        /// <param name="methodParams">parameters of the frames method.</param>
        /// <param name="exceptionType">Exception type..</param>
        /// <param name="osExceptionType">OS exception type. (aka. SIGNAL).</param>
        public ReasonStackFrame(string className = default(string), string method = default(string), bool? classMethod = default(bool?), string file = default(string), int? line = default(int?), bool? appCode = default(bool?), string frameworkName = default(string), string codeFormatted = default(string), string codeRaw = default(string), LanguageEnum? language = default(LanguageEnum?), string methodParams = default(string), string exceptionType = default(string), string osExceptionType = default(string))
        {
            this.ClassName = className;
            this.Method = method;
            this.ClassMethod = classMethod;
            this.File = file;
            this.Line = line;
            this.AppCode = appCode;
            this.FrameworkName = frameworkName;
            this.CodeFormatted = codeFormatted;
            this.CodeRaw = codeRaw;
            this.Language = language;
            this.MethodParams = methodParams;
            this.ExceptionType = exceptionType;
            this.OsExceptionType = osExceptionType;
        }
        
        /// <summary>
        /// name of the class
        /// </summary>
        /// <value>name of the class</value>
        [DataMember(Name="class_name", EmitDefaultValue=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// name of the method
        /// </summary>
        /// <value>name of the method</value>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public string Method { get; set; }

        /// <summary>
        /// is a class method
        /// </summary>
        /// <value>is a class method</value>
        [DataMember(Name="class_method", EmitDefaultValue=false)]
        public bool? ClassMethod { get; set; }

        /// <summary>
        /// name of the file
        /// </summary>
        /// <value>name of the file</value>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public string File { get; set; }

        /// <summary>
        /// line number
        /// </summary>
        /// <value>line number</value>
        [DataMember(Name="line", EmitDefaultValue=false)]
        public int? Line { get; set; }

        /// <summary>
        /// this line isn&#x27;t from any framework
        /// </summary>
        /// <value>this line isn&#x27;t from any framework</value>
        [DataMember(Name="app_code", EmitDefaultValue=false)]
        public bool? AppCode { get; set; }

        /// <summary>
        /// Name of the framework
        /// </summary>
        /// <value>Name of the framework</value>
        [DataMember(Name="framework_name", EmitDefaultValue=false)]
        public string FrameworkName { get; set; }

        /// <summary>
        /// Formatted frame string
        /// </summary>
        /// <value>Formatted frame string</value>
        [DataMember(Name="code_formatted", EmitDefaultValue=false)]
        public string CodeFormatted { get; set; }

        /// <summary>
        /// Unformatted Frame string
        /// </summary>
        /// <value>Unformatted Frame string</value>
        [DataMember(Name="code_raw", EmitDefaultValue=false)]
        public string CodeRaw { get; set; }


        /// <summary>
        /// parameters of the frames method
        /// </summary>
        /// <value>parameters of the frames method</value>
        [DataMember(Name="method_params", EmitDefaultValue=false)]
        public string MethodParams { get; set; }

        /// <summary>
        /// Exception type.
        /// </summary>
        /// <value>Exception type.</value>
        [DataMember(Name="exception_type", EmitDefaultValue=false)]
        public string ExceptionType { get; set; }

        /// <summary>
        /// OS exception type. (aka. SIGNAL)
        /// </summary>
        /// <value>OS exception type. (aka. SIGNAL)</value>
        [DataMember(Name="os_exception_type", EmitDefaultValue=false)]
        public string OsExceptionType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReasonStackFrame {\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  ClassMethod: ").Append(ClassMethod).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Line: ").Append(Line).Append("\n");
            sb.Append("  AppCode: ").Append(AppCode).Append("\n");
            sb.Append("  FrameworkName: ").Append(FrameworkName).Append("\n");
            sb.Append("  CodeFormatted: ").Append(CodeFormatted).Append("\n");
            sb.Append("  CodeRaw: ").Append(CodeRaw).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  MethodParams: ").Append(MethodParams).Append("\n");
            sb.Append("  ExceptionType: ").Append(ExceptionType).Append("\n");
            sb.Append("  OsExceptionType: ").Append(OsExceptionType).Append("\n");
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
            return this.Equals(input as ReasonStackFrame);
        }

        /// <summary>
        /// Returns true if ReasonStackFrame instances are equal
        /// </summary>
        /// <param name="input">Instance of ReasonStackFrame to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReasonStackFrame input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClassName == input.ClassName ||
                    (this.ClassName != null &&
                    this.ClassName.Equals(input.ClassName))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.ClassMethod == input.ClassMethod ||
                    (this.ClassMethod != null &&
                    this.ClassMethod.Equals(input.ClassMethod))
                ) && 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.Line == input.Line ||
                    (this.Line != null &&
                    this.Line.Equals(input.Line))
                ) && 
                (
                    this.AppCode == input.AppCode ||
                    (this.AppCode != null &&
                    this.AppCode.Equals(input.AppCode))
                ) && 
                (
                    this.FrameworkName == input.FrameworkName ||
                    (this.FrameworkName != null &&
                    this.FrameworkName.Equals(input.FrameworkName))
                ) && 
                (
                    this.CodeFormatted == input.CodeFormatted ||
                    (this.CodeFormatted != null &&
                    this.CodeFormatted.Equals(input.CodeFormatted))
                ) && 
                (
                    this.CodeRaw == input.CodeRaw ||
                    (this.CodeRaw != null &&
                    this.CodeRaw.Equals(input.CodeRaw))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.MethodParams == input.MethodParams ||
                    (this.MethodParams != null &&
                    this.MethodParams.Equals(input.MethodParams))
                ) && 
                (
                    this.ExceptionType == input.ExceptionType ||
                    (this.ExceptionType != null &&
                    this.ExceptionType.Equals(input.ExceptionType))
                ) && 
                (
                    this.OsExceptionType == input.OsExceptionType ||
                    (this.OsExceptionType != null &&
                    this.OsExceptionType.Equals(input.OsExceptionType))
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
                if (this.ClassName != null)
                    hashCode = hashCode * 59 + this.ClassName.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.ClassMethod != null)
                    hashCode = hashCode * 59 + this.ClassMethod.GetHashCode();
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                if (this.Line != null)
                    hashCode = hashCode * 59 + this.Line.GetHashCode();
                if (this.AppCode != null)
                    hashCode = hashCode * 59 + this.AppCode.GetHashCode();
                if (this.FrameworkName != null)
                    hashCode = hashCode * 59 + this.FrameworkName.GetHashCode();
                if (this.CodeFormatted != null)
                    hashCode = hashCode * 59 + this.CodeFormatted.GetHashCode();
                if (this.CodeRaw != null)
                    hashCode = hashCode * 59 + this.CodeRaw.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.MethodParams != null)
                    hashCode = hashCode * 59 + this.MethodParams.GetHashCode();
                if (this.ExceptionType != null)
                    hashCode = hashCode * 59 + this.ExceptionType.GetHashCode();
                if (this.OsExceptionType != null)
                    hashCode = hashCode * 59 + this.OsExceptionType.GetHashCode();
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
