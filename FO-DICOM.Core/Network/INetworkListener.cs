// Copyright (c) 2012-2021 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

using FellowOakDicom.Network.Tls;
using System.Threading;
using System.Threading.Tasks;

namespace FellowOakDicom.Network
{

    /// <summary>
    /// Interface for listening to network stream connections.
    /// </summary>
    public interface INetworkListener
    {
        /// <summary>
        /// Start listening.
        /// </summary>
        /// <returns>An await:able <see cref="Task"/>.</returns>
        Task StartAsync();
        /// <summary>
        /// Stop listening.
        /// </summary>
        void Stop();

        /// <summary>
        /// Wait until a network stream is trying to connect, and return the accepted stream.
        /// </summary>
        /// <param name="tlsAcceptor">Handler to accept authenticated connections.</param>
        /// <param name="noDelay">No delay?</param>
        /// <param name="token">Cancellation token.</param>
        /// <returns>Connected network stream.</returns>
        Task<INetworkStream> AcceptNetworkStreamAsync(ITlsAcceptor tlsAcceptor, bool noDelay, CancellationToken token);
    }
}
