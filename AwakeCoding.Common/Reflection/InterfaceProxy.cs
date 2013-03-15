using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Security.Permissions;
using System.Text;

namespace AwakeCoding.Reflection
{
    /// <summary>
    /// Based on original code by Rory Primrose
    /// http://www.neovolve.com/post/2010/07/17/Creating-proxies-with-RealProxy.aspx
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class InterfaceProxy<T> : RealProxy
    {
        public InterfaceProxy()
            : base(typeof(T))
        {
        }

        // The object instance on which the calls will be routed
        public object TargetInstance { get; set; }

        public Type TargetType { get; set; }

        public T GetStrongTypedProxy()
        {
            return (T) GetTransparentProxy();
        }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.Infrastructure)]
        [DebuggerStepThrough]
        public override IMessage Invoke(IMessage msg)
        {
            Debug.Assert(msg != null, "No message has been provided");

            ReturnMessage responseMessage;
            Object response = null;
            Exception caughtException = null;

            try
            {
                String methodName = (String)msg.Properties["__MethodName"];
                Type[] parameterTypes = (Type[])msg.Properties["__MethodSignature"];
    
                MethodBase method = typeof(T).GetMethod(methodName, parameterTypes);
                if (method == null)
                {
                    // Look for method definition in ancestor interfaces
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

                    response = InvokeMethod(method, parameterTypes, parameters);
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

        private object InvokeMethod(MethodBase method, Type[] parameterTypes, object[] parameters)
        {
            if (TargetInstance != null)
            {
                if (TargetType == null)
                {
                    TargetType = TargetInstance.GetType();
                }

                MethodBase underlyingMethod = TargetType.GetMethod(method.Name, parameterTypes);
                if (method == null)
                {
                    // Look for method definition in ancestor interfaces
                    foreach (Type interfaceType in TargetType.GetInterfaces())
                    {
                        underlyingMethod = interfaceType.GetMethod(method.Name, parameterTypes);
                        if (underlyingMethod != null)
                        {
                            break;
                        }
                    }
                }
                
                //MethodInfo underlyingMethod = underlyingType.GetMethod(method.Name);

                if (underlyingMethod == null)
                {
                    Debug.WriteLine("No underlying method found for " + method.Name);
                    throw new NotImplementedException(String.Format("Method {0} not found in underlying object", method.Name));
                }
                else
                {
                    return underlyingMethod.Invoke(TargetInstance, parameters);
                }
            }

            return null;
        }
    }
}
