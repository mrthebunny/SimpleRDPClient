using AwakeCoding.Common;
using AwakeCoding.FreeRDPClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwakeCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            TestProxy();

            Console.WriteLine("Done. Press a key to exit.");
            Console.ReadKey();
        }


        private static void TestProxy()
        {
            TestProxy<ISecuredSettings2> test = new TestProxy<ISecuredSettings2>();

            SecuredSettingsStub stub = new SecuredSettingsStub();
            test.UnderlyingObject = stub;

            stub.BinaryPassword = "abcdefg";

            ISecuredSettings2 settings = (ISecuredSettings2)test.GetTransparentProxy();

            settings.ClearTextPassword = "test";
            Console.WriteLine("sub.BinaryPassword = " + settings.BinaryPassword);

            try
            {
                Console.WriteLine("sub.BinaryPassword2 = " + settings.BinaryPassword2);
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine("Caught NotImplementedException (as expected): " + ex.Message);
            }
        }
    }
}
