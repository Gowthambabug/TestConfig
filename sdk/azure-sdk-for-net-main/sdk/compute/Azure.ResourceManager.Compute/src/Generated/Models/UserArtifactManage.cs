// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The UserArtifactManage. </summary>
    public partial class UserArtifactManage
    {
        /// <summary> Initializes a new instance of UserArtifactManage. </summary>
        /// <param name="install"> Required. The path and arguments to install the gallery application. This is limited to 4096 characters. </param>
        /// <param name="remove"> Required. The path and arguments to remove the gallery application. This is limited to 4096 characters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="install"/> or <paramref name="remove"/> is null. </exception>
        public UserArtifactManage(string install, string @remove)
        {
            if (install == null)
            {
                throw new ArgumentNullException(nameof(install));
            }
            if (@remove == null)
            {
                throw new ArgumentNullException(nameof(@remove));
            }

            Install = install;
            Remove = @remove;
        }

        /// <summary> Initializes a new instance of UserArtifactManage. </summary>
        /// <param name="install"> Required. The path and arguments to install the gallery application. This is limited to 4096 characters. </param>
        /// <param name="remove"> Required. The path and arguments to remove the gallery application. This is limited to 4096 characters. </param>
        /// <param name="update"> Optional. The path and arguments to update the gallery application. If not present, then update operation will invoke remove command on the previous version and install command on the current version of the gallery application. This is limited to 4096 characters. </param>
        internal UserArtifactManage(string install, string @remove, string update)
        {
            Install = install;
            Remove = @remove;
            Update = update;
        }

        /// <summary> Required. The path and arguments to install the gallery application. This is limited to 4096 characters. </summary>
        public string Install { get; set; }
        /// <summary> Required. The path and arguments to remove the gallery application. This is limited to 4096 characters. </summary>
        public string Remove { get; set; }
        /// <summary> Optional. The path and arguments to update the gallery application. If not present, then update operation will invoke remove command on the previous version and install command on the current version of the gallery application. This is limited to 4096 characters. </summary>
        public string Update { get; set; }
    }
}