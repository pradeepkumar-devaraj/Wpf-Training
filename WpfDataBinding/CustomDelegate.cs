using System;

namespace WpfDataBinding
{
    delegate string Handler(int args);

    class MyClass
    {
        private Handler EventHandler = MyMethod;

        private static string MyMethod(int args)
        {
            throw new Exception();
        }
    }
}
