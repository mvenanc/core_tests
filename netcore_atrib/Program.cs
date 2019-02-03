using System;
using System.Reflection;

namespace netcore_atrib {

    public class MySpecialAttribute : Attribute { }

    public class GotchaAttribute : Attribute {
        public GotchaAttribute (Foo myClass, string str) {

        }
    }

    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct)]
    public class MyAttributeForClassAndStructOnly : Attribute {

    }

    [Obsolete]
    public class MyClass {

    }

    [Obsolete ("ThisClass is obsolete. Use ThisClass2 instead.")]
    public class ThisClass {

    }

    [MySpecialAttribute]
    public class SomeOtherClass {

    }

    // [Gotcha (new Foo (), "test")] // does not compile
    // public class AttributeFail {

    // }

    public class Foo {
        // if the below attribute was uncommented, it would cause a compiler error
        // [MyAttributeForClassAndStructOnly]
        public Foo () { }
    }

    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");

            // MyClass teste = new MyClass ();
            // ThisClass t = new ThisClass ();

            // SomeOtherClass s = new SomeOtherClass ();

            TypeInfo typeInfo = typeof (MyClass).GetTypeInfo ();
            Console.WriteLine ("The assembly qualified name of MyClass is " + typeInfo.AssemblyQualifiedName);

            var attrs = typeInfo.GetCustomAttributes ();
            foreach (var attr in attrs)
                Console.WriteLine ("Attribute on MyClass: " + attr.GetType ().Name);

        }
    }
}