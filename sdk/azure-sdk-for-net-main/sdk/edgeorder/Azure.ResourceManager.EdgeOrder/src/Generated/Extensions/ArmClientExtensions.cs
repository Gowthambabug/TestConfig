// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.EdgeOrder
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region AddressResource
        /// <summary> Gets an object representing a AddressResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AddressResource" /> object. </returns>
        public static AddressResource GetAddressResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                AddressResource.ValidateResourceId(id);
                return new AddressResource(client, id);
            }
            );
        }
        #endregion

        #region OrderResource
        /// <summary> Gets an object representing a OrderResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OrderResource" /> object. </returns>
        public static OrderResource GetOrderResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                OrderResource.ValidateResourceId(id);
                return new OrderResource(client, id);
            }
            );
        }
        #endregion

        #region OrderItemResource
        /// <summary> Gets an object representing a OrderItemResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OrderItemResource" /> object. </returns>
        public static OrderItemResource GetOrderItemResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                OrderItemResource.ValidateResourceId(id);
                return new OrderItemResource(client, id);
            }
            );
        }
        #endregion
    }
}