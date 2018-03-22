using System;
using System.Collections.Generic;
using System.Configuration;
using log4net.Appender;
using log4net.Core;
using Rollbar;

namespace log4net.Rollbar
{
    public class RollbarAppender : AppenderSkeleton
    {
        /// <summary>
        /// Sends the given event to Rollbar
        /// </summary>
        /// <param name="loggingEvent">The event to report</param>
        protected override void Append(LoggingEvent loggingEvent)
        {
            if (loggingEvent.Level >= Level.Critical)
            {
                if (loggingEvent.ExceptionObject != null)
                    RollbarLocator.RollbarInstance.Critical(loggingEvent.ExceptionObject, null);
                else
                    RollbarLocator.RollbarInstance.Critical(loggingEvent.RenderedMessage, null);
            }
            else if (loggingEvent.Level >= Level.Error)
            {
                if (loggingEvent.ExceptionObject != null)
                    RollbarLocator.RollbarInstance.Error(loggingEvent.ExceptionObject, null);
                else
                    RollbarLocator.RollbarInstance.Error(loggingEvent.RenderedMessage, null);
            }
            else if (loggingEvent.Level >= Level.Warn)
            {
                if (loggingEvent.ExceptionObject != null)
                    RollbarLocator.RollbarInstance.Warning(loggingEvent.ExceptionObject, null);
                else
                    RollbarLocator.RollbarInstance.Warning(loggingEvent.RenderedMessage, null);
            }
            else if (loggingEvent.Level >= Level.Info)
            {
                if (loggingEvent.ExceptionObject != null)
                    RollbarLocator.RollbarInstance.Info(loggingEvent.ExceptionObject, null);
                else
                    RollbarLocator.RollbarInstance.Info(loggingEvent.RenderedMessage, null);
            }
            else if (loggingEvent.Level >= Level.Debug)
            {
                if (loggingEvent.ExceptionObject != null)
                    RollbarLocator.RollbarInstance.Debug(loggingEvent.ExceptionObject, null);
                else
                    RollbarLocator.RollbarInstance.Debug(loggingEvent.RenderedMessage, null);
            }
        }
    }
}
