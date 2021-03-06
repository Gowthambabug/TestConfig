// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.MixedReality.ObjectAnchors.Conversion.Models;

namespace Azure.MixedReality.ObjectAnchors.Conversion
{
    /// <summary> Represents an ingestion configuration. </summary>
    public partial class AssetConversionConfiguration
    {

        /// <summary> Initializes a new instance of AssetConversionConfiguration. </summary>
        /// <param name="assetDimensionsWrapper"></param>
        /// <param name="boundingBoxCenterWrapper"></param>
        /// <param name="gravityWrapper"></param>
        /// <param name="keyFrameIndexes"> Indices of Key Frames. </param>
        /// <param name="groundTruthTrajectoryCameraPoses"> Ground truth trajectory. </param>
        /// <param name="principalAxisWrapper"></param>
        /// <param name="scale"> Scale of transformation of asset units into meter space. </param>
        /// <param name="supportingPlaneWrapper"></param>
        /// <param name="testTrajectoryCameraPoses"> Test Trajectory. </param>
        internal AssetConversionConfiguration(Vector3 assetDimensionsWrapper, Vector3 boundingBoxCenterWrapper, Vector3 gravityWrapper, IReadOnlyList<int> keyFrameIndexes, IReadOnlyList<TrajectoryPose> groundTruthTrajectoryCameraPoses, Quaternion principalAxisWrapper, float scale, Vector4 supportingPlaneWrapper, IReadOnlyList<TrajectoryPose> testTrajectoryCameraPoses)
        {
            AssetDimensionsWrapper = assetDimensionsWrapper;
            BoundingBoxCenterWrapper = boundingBoxCenterWrapper;
            GravityWrapper = gravityWrapper;
            KeyFrameIndexes = keyFrameIndexes;
            GroundTruthTrajectoryCameraPoses = groundTruthTrajectoryCameraPoses;
            PrincipalAxisWrapper = principalAxisWrapper;
            Scale = scale;
            SupportingPlaneWrapper = supportingPlaneWrapper;
            TestTrajectoryCameraPoses = testTrajectoryCameraPoses;
        }
    }
}
