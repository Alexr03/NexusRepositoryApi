/* 
 * Nexus Repository Manager REST API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 3.26.1-02
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
using SwaggerDateConverter = SonaTypeNexusRepoApi.Client.SwaggerDateConverter;

namespace SonaTypeNexusRepoApi.Model
{
    /// <summary>
    /// ContentSelectorApiCreateRequest
    /// </summary>
    [DataContract]
    public partial class ContentSelectorApiCreateRequest :  IEquatable<ContentSelectorApiCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentSelectorApiCreateRequest" /> class.
        /// </summary>
        /// <param name="name">The content selector name cannot be changed after creation.</param>
        /// <param name="description">A human-readable description.</param>
        /// <param name="expression">The expression used to identify content.</param>
        public ContentSelectorApiCreateRequest(string name = default(string), string description = default(string), string expression = default(string))
        {
            this.Name = name;
            this.Description = description;
            this.Expression = expression;
        }
        
        /// <summary>
        /// The content selector name cannot be changed after creation
        /// </summary>
        /// <value>The content selector name cannot be changed after creation</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A human-readable description
        /// </summary>
        /// <value>A human-readable description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The expression used to identify content
        /// </summary>
        /// <value>The expression used to identify content</value>
        [DataMember(Name="expression", EmitDefaultValue=false)]
        public string Expression { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentSelectorApiCreateRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
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
            return this.Equals(input as ContentSelectorApiCreateRequest);
        }

        /// <summary>
        /// Returns true if ContentSelectorApiCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ContentSelectorApiCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentSelectorApiCreateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Expression == input.Expression ||
                    (this.Expression != null &&
                    this.Expression.Equals(input.Expression))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Expression != null)
                    hashCode = hashCode * 59 + this.Expression.GetHashCode();
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
            // Name (string) pattern
            Regex regexName = new Regex(@"^[a-zA-Z0-9\\-]{1}[a-zA-Z0-9_\\-\\.]*$", RegexOptions.CultureInvariant);
            if (false == regexName.Match(this.Name).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
            }

            yield break;
        }
    }

}
