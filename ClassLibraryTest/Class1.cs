using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest
{
    using MyNamespace;
    public class Class1
    {
        MyNamespace.MyClass
    }
    class MyClass
    {

    }

}
namespace MyNamespace
{
    class MyClass
    {
        ClassLibraryTest.Class1


    }

}
