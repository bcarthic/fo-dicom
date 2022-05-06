﻿// Copyright (c) 2012-2021 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace FellowOakDicom.Imaging.Codec
{

    /// <summary>
    /// Base class for DICOM codec parameters.
    /// </summary>
    public class DicomCodecParams
    {
        /// <summary>
        /// Protected base class constructor.
        /// </summary>
        protected DicomCodecParams()
        {
            this.Logger = Setup.ServiceProvider.GetRequiredService<ILoggerFactory>().CreateLogger("FellowOakDicom.Imaging.Codec");
        }

        /// <summary>
        /// Gets or sets the DICOM codec parameters <see cref="Logger"/>.
        /// </summary>
        public ILogger Logger { get; protected set; }
    }
}
