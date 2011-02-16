using System;

namespace templateproject.Infrastructure.Log
{
    public interface ILog
    {
        //bool IsTraceEnabled { get; }
        bool IsDebugEnabled { get; }
        bool IsInfoEnabled { get; }
        bool IsWarnEnabled { get; }
        bool IsErrorEnabled { get; }
        bool IsFatalEnabled { get; }

        void Debug(object message);
        void Debug(string format, params object[] args);
        void Debug(object message, Exception t);

        void Info(object message);
        void Info(string format, params object[] args);
        void Info(object message, Exception t);

        void Warn(object message);
        void Warn(string format, params object[] args);
        void Warn(object message, Exception t);

        void Error(object message);
        void Error(string format, params object[] args);
        void Error(object message, Exception t);

        void Fatal(object message);
        void Fatal(string format, params object[] args);
        void Fatal(object message, Exception t);
    }
}