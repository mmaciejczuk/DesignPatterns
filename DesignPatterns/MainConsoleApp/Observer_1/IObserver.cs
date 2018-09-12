using System;
using System.Collections.Generic;
using System.Text;

namespace MainConsoleApp.Observer_1
{
    public interface IObserver
    {
        void Update(float price);
    }
}
