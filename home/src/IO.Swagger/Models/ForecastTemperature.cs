/*
 * home
 *
 * The API for the Home Starter project
 *
 * OpenAPI spec version: 1.0.3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ForecastTemperature :  IEquatable<ForecastTemperature>
    { 
        /// <summary>
        /// Gets or Sets Low
        /// </summary>
        [DataMember(Name="low")]
        public double? Low { get; set; }

        /// <summary>
        /// Gets or Sets High
        /// </summary>
        [DataMember(Name="high")]
        public double? High { get; set; }

        /// <summary>
        /// Gets or Sets Morning
        /// </summary>
        [DataMember(Name="morning")]
        public double? Morning { get; set; }

        /// <summary>
        /// Gets or Sets Day
        /// </summary>
        [DataMember(Name="day")]
        public double? Day { get; set; }

        /// <summary>
        /// Gets or Sets Evening
        /// </summary>
        [DataMember(Name="evening")]
        public double? Evening { get; set; }

        /// <summary>
        /// Gets or Sets Night
        /// </summary>
        [DataMember(Name="night")]
        public double? Night { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForecastTemperature {\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Morning: ").Append(Morning).Append("\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            sb.Append("  Evening: ").Append(Evening).Append("\n");
            sb.Append("  Night: ").Append(Night).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ForecastTemperature)obj);
        }

        /// <summary>
        /// Returns true if ForecastTemperature instances are equal
        /// </summary>
        /// <param name="other">Instance of ForecastTemperature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForecastTemperature other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Low == other.Low ||
                    Low != null &&
                    Low.Equals(other.Low)
                ) && 
                (
                    High == other.High ||
                    High != null &&
                    High.Equals(other.High)
                ) && 
                (
                    Morning == other.Morning ||
                    Morning != null &&
                    Morning.Equals(other.Morning)
                ) && 
                (
                    Day == other.Day ||
                    Day != null &&
                    Day.Equals(other.Day)
                ) && 
                (
                    Evening == other.Evening ||
                    Evening != null &&
                    Evening.Equals(other.Evening)
                ) && 
                (
                    Night == other.Night ||
                    Night != null &&
                    Night.Equals(other.Night)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Low != null)
                    hashCode = hashCode * 59 + Low.GetHashCode();
                    if (High != null)
                    hashCode = hashCode * 59 + High.GetHashCode();
                    if (Morning != null)
                    hashCode = hashCode * 59 + Morning.GetHashCode();
                    if (Day != null)
                    hashCode = hashCode * 59 + Day.GetHashCode();
                    if (Evening != null)
                    hashCode = hashCode * 59 + Evening.GetHashCode();
                    if (Night != null)
                    hashCode = hashCode * 59 + Night.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ForecastTemperature left, ForecastTemperature right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ForecastTemperature left, ForecastTemperature right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}