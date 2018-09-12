using System;
using System.Collections.Generic;
using System.Text;

namespace MainConsoleApp.Observer_1
{
    public class ExampleProduct : ASubject
    {
        public void ChangePrice(float price)
        {
            Notify(price);
        }
    }
}
