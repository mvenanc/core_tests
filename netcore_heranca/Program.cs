using System;
using System.Reflection;

namespace netcore_heranca {
    public abstract class A {
        private int value = 10;

        public abstract void Method1 ();

        // public class B : A {
        //     public int GetValue () {
        //         return this.value;
        //     }
        // }
    }

    public class B : A {
        public void Method3 () { }
        public override void Method1 () // Generates CS0506.
        {
            // Do something else.
        }
    }

    // public class C : A
    // {
    //     public C()
    //     {
    //     }
    // }

    public class SimpleClass { }

    class Program 
    {
        static void Main (string[] args) {
            Type t = typeof (SimpleClass);
            BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public |
                BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;
            MemberInfo[] members = t.GetMembers (flags);
            Console.WriteLine ($"Type {t.Name} has {members.Length} members: ");
            foreach (var member in members) {
                string access = "";
                string stat = "";
                var method = member as MethodBase;
                if (method != null) {
                    if (method.IsPublic)
                        access = " Public";
                    else if (method.IsPrivate)
                        access = " Private";
                    else if (method.IsFamily)
                        access = " Protected";
                    else if (method.IsAssembly)
                        access = " Internal";
                    else if (method.IsFamilyOrAssembly)
                        access = " Protected Internal ";
                    if (method.IsStatic)
                        stat = " Static";
                }
                var output = $"{member.Name} ({member.MemberType}): {access}{stat}, Declared by {member.DeclaringType}";
                Console.WriteLine (output);

                //Membros implicitos herdados de Object
                // The example displays the following output:
                //	Type SimpleClass has 9 members:
                //	ToString (Method):  Public, Declared by System.Object
                //	Equals (Method):  Public, Declared by System.Object
                //	Equals (Method):  Public Static, Declared by System.Object
                //	ReferenceEquals (Method):  Public Static, Declared by System.Object
                //	GetHashCode (Method):  Public, Declared by System.Object
                //	GetType (Method):  Public, Declared by System.Object
                //	Finalize (Method):  Internal, Declared by System.Object
                //	MemberwiseClone (Method):  Internal, Declared by System.Object
                //	.ctor (Constructor):  Public, Declared by SimpleClass

                SimpleClass sc = new SimpleClass();
                Console.WriteLine(sc.ToString());

            }
        }

    }
}