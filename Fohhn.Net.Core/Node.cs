/*
 * Copyright 2024 Fohhn
 *
 * licensed under the MIT License, see LICENSE for more information
 */

namespace Fohhn.Net.Core
{
    public abstract class Node
    {
        protected bool run = true;

        public abstract void Send(byte[] cmd);
        public event EventHandler<DataReceiveEventArgs>? DataReceived;

        protected void OnDataReceived(byte[]? receivedBytes)
        {
            if (receivedBytes != null)
            {
                DataReceived?.Invoke(this, new DataReceiveEventArgs(receivedBytes));
            }
        }

        public virtual void Close()
        {
            run = false;
        }
    }
}
