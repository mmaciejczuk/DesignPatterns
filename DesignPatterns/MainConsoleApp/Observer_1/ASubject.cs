using System;
using System.Collections.Generic;
using System.Text;

namespace MainConsoleApp.Observer_1
{
    // Absctract class ASubject
    public class ASubject
    {
        // First kind of implementation
        List<Shop> list = new List<Shop>();
        // Second kind of implementation
        public delegate void StatusUpdate(float price);
        public event StatusUpdate OnStatusUpdate = null;

        public void Attach(Shop product)
        {
            list.Add(product);
        }

        public void Detach(Shop product)
        {
            list.Remove(product);
        }

        public void Attach2(Shop product)
        {
            OnStatusUpdate += new StatusUpdate(product.Update);
        }

        public void Detach2(Shop product)
        {
            OnStatusUpdate -= new StatusUpdate(product.Update);
        }

        public void Notify(float price)
        {
            // for first kind
            foreach (Shop p in list)
            {
                p.Update(price);
            }

            // for second kind
            OnStatusUpdate?.Invoke(price);
        }
    }
}
