namespace templateproject.Infrastructure.Log
{
    /// <summary>
    /// Factory class for logging. 
    /// is done for system debug purposes. All other application logging 
    /// necessary for application statistics is outside the scope of this module.
    /// </summary>
    public class LogFactory
    {
        /// <summary>
        /// The method returns a logger for Domain layer.
        /// </summary>
        /// <returns>ILog</returns>
        public static ILog GetDomainLayerLogger()
        {
            return NLogLoggerProxy.GetLogger("DomainLayerLogger");
        }

        /// <summary>
        /// The method returns a logger for Application layer.
        /// </summary>
        /// <returns>ILog</returns>
        public static ILog GetApplicationLayerLogger()
        {
            return NLogLoggerProxy.GetLogger("ApplicationLayerLogger");
        }

        /// <summary>
        /// The method returns a logger for Interface layer.
        /// </summary>
        /// <returns>ILog</returns>
        public static ILog GetInterfaceLayerLogger()
        {
            return NLogLoggerProxy.GetLogger("InterfaceLayerLogger");
        }

        /// <summary>
        /// The method returns a logger for External Service.
        /// </summary>
        /// <returns>ILog</returns>
        public static ILog GetExternalServiceLogger()
        {
            return NLogLoggerProxy.GetLogger("ExternalServiceLogger");
        }

        /// <summary>
        /// The method returns a logger for Specification.
        /// </summary>
        /// <returns>ILog</returns>
        public static ILog GetSpecificationLogger()
        {
            return NLogLoggerProxy.GetLogger("SpecificationLogger");
        }
    }
}