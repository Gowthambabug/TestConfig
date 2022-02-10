// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Large face list object.
    /// </summary>
    public partial class LargeFaceList
    {
        /// <summary>
        /// Initializes a new instance of the LargeFaceList class.
        /// </summary>
        public LargeFaceList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LargeFaceList class.
        /// </summary>
        /// <param name="largeFaceListId">LargeFaceListId of the target large
        /// face list.</param>
        /// <param name="name">User defined name, maximum length is
        /// 128.</param>
        /// <param name="userData">User specified data. Length should not
        /// exceed 16KB.</param>
        /// <param name="recognitionModel">Possible values include:
        /// 'recognition_01', 'recognition_02', 'recognition_03',
        /// 'recognition_04'</param>
        public LargeFaceList(string largeFaceListId, string name, string userData = default(string), string recognitionModel = default(string))
        {
            LargeFaceListId = largeFaceListId;
            Name = name;
            UserData = userData;
            RecognitionModel = recognitionModel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets largeFaceListId of the target large face list.
        /// </summary>
        [JsonProperty(PropertyName = "largeFaceListId")]
        public string LargeFaceListId { get; set; }

        /// <summary>
        /// Gets or sets user defined name, maximum length is 128.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets user specified data. Length should not exceed 16KB.
        /// </summary>
        [JsonProperty(PropertyName = "userData")]
        public string UserData { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'recognition_01',
        /// 'recognition_02', 'recognition_03', 'recognition_04'
        /// </summary>
        [JsonProperty(PropertyName = "recognitionModel")]
        public string RecognitionModel { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (LargeFaceListId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LargeFaceListId");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (LargeFaceListId != null)
            {
                if (LargeFaceListId.Length > 64)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "LargeFaceListId", 64);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(LargeFaceListId, "^[a-z0-9-_]+$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "LargeFaceListId", "^[a-z0-9-_]+$");
                }
            }
            if (Name != null)
            {
                if (Name.Length > 128)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 128);
                }
                if (Name.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 1);
                }
            }
            if (UserData != null)
            {
                if (UserData.Length > 16384)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "UserData", 16384);
                }
            }
        }
    }
}