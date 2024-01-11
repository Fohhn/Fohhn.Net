/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

namespace Fohhn.Net.Core
{
    public class DataReceiveEventArgs(byte[] data) : EventArgs
    {
        public readonly byte[] Data = data;
    }
}
