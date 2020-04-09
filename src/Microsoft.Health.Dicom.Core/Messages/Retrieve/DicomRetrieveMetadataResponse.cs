﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Net;
using Dicom;
using EnsureThat;

namespace Microsoft.Health.Dicom.Core.Messages.Retrieve
{
    public class DicomRetrieveMetadataResponse : BaseStatusCodeResponse
    {
        public DicomRetrieveMetadataResponse(int statusCode)
            : base(statusCode)
        {
        }

        public DicomRetrieveMetadataResponse(HttpStatusCode statusCode, IEnumerable<DicomDataset> responseMetadata)
            : base((int)statusCode)
        {
            EnsureArg.IsNotNull(responseMetadata, nameof(responseMetadata));
            ResponseMetadata = responseMetadata;
        }

        public IEnumerable<DicomDataset> ResponseMetadata { get; }
    }
}