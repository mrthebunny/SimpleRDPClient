using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Security.Permissions;
using System.Text;

namespace AwakeCoding
{
    public class TestProxy<T> : RealProxy
    {
        public TestProxy()
            : base(typeof(T))
        {
        }

        public object UnderlyingObject { get; set; }

        private void AnalyzeSource()
        {
            Debug.Assert(UnderlyingObject != null, "No source has been set.");

            Type type = UnderlyingObject.GetType();
            Debug.WriteLine("Underlying object type: " + type.FullName);

            PropertyInfo[] props = type.GetProperties();
            MethodInfo[] methods = type.GetMethods();

            if (props.Length == 0)
            {
                Debug.WriteLine("No property found...");
            }

            foreach (PropertyInfo property in props)
            {
                Debug.WriteLine("property found: " + property.Name);
                Debug.WriteLine("setter: " + property.GetSetMethod().Name);
            }

            if (methods.Length == 0)
            {
                Debug.WriteLine("No methods found...");
            }

            foreach (MethodInfo method in methods)
            {
                Debug.WriteLine("method found: " + method.Name);
            }
        }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.Infrastructure)]
        //[DebuggerStepThrough]
        public override IMessage Invoke(IMessage msg)
        {
            Debug.Assert(msg != null, "No message has been provided");

            //AnalyzeSource();

            ReturnMessage responseMessage;
            Object response = null;
            Exception caughtException = null;

            try
            {
                String methodName = (String)msg.Properties["__MethodName"];
                Type[] parameterTypes = (Type[])msg.Properties["__MethodSignature"];

                foreach (MethodBase m in typeof(T).GetMethods(BindingFlags.FlattenHierarchy))
                {
                    Debug.WriteLine("lookup: " + m.Name);
                }
                
                MethodBase method = typeof(T).GetMethod(methodName, parameterTypes);
                if (method == null)
                {
                    foreach (Type interfaceType in typeof(T).GetInterfaces())
                    {
                        method = interfaceType.GetMethod(methodName, parameterTypes);
                        if (method != null)
                        {
                            break;
                        }
                    }
                }

                Object[] parameters = (Object[])msg.Properties["__Args"];

                // ______________________________________________________________________________
                //
                // Start the logic for handling the method invocation on this proxy
                // ______________________________________________________________________________
                if (method != null)
                {
                    Debug.WriteLine("Invoking " + method.Name + " with the following parameters:");

                    for (int index = 0; index < parameters.Length; index++)
                    {
                        Debug.WriteLine(parameterTypes[index].Name + " - " + parameters[index]);
                    }

                    response = InvokeMethod(method, parameters);
                }
                else
                {
                    Debug.WriteLine("Method " + methodName + " not found!");
                }


                // ______________________________________________________________________________
                //
                // End the logic for handling the method invocation on this proxy
                // ______________________________________________________________________________
            }
            catch (Exception ex)
            {
                // Store the caught exception
                caughtException = ex;
            }

            IMethodCallMessage message = msg as IMethodCallMessage;

            // Check if there is an exception
            if (caughtException == null)
            {
                // Return the response from the service
                responseMessage = new ReturnMessage(response, null, 0, null, message);
            }
            else
            {
                // Return the exception thrown by the service
                responseMessage = new ReturnMessage(caughtException, message);
            }

            // Return the response message
            return responseMessage;
        }

        private object InvokeMethod(MethodBase method, object[] parameters)
        {
            if (UnderlyingObject != null)
            {
                Type underlyingType = UnderlyingObject.GetType();
                MethodInfo underlyingMethod = underlyingType.GetMethod(method.Name);

                if (underlyingMethod == null)
                {
                    Debug.WriteLine("No underlying method found for " + method.Name);
                    throw new NotImplementedException(String.Format("Method {0} not found in underlying object", method.Name));
                }
                else
                {
                    return underlyingMethod.Invoke(UnderlyingObject, parameters);
                }
            }

            return null;
        }
    }
}
