using System;
using System.IO;
using System.Windows.Forms;

namespace GWT.Logger
{
    /// <summary>
    /// Class handling the logger instance and whole logging
    /// </summary>
    public static class Log
    {
        /// <summary>
        /// The logger instance
        /// </summary>
        private static readonly log4net.ILog _logger;

        /// <summary>
        /// Initializes the <see cref="Log"/> class.
        /// </summary>
        static Log()
        {
            log4net.Config.XmlConfigurator.Configure(new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GwtLogConfig.xml")));
            _logger = log4net.LogManager.GetLogger("GWTLogger");
        }

        /// <summary>
        /// Logs the debug.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        public static void LogDebug(string message, params object[] args)
        {
            _logger.Debug(string.Format(message, args));
        }

        /// <summary>
        /// Logs the error.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        public static void LogError(string message, params object[] args)
        {
            _logger.Error(string.Format(message, args));
        }

        /// <summary>
        /// Logs the error and show message box.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        public static void LogErrorAndShowMessageBox(string message, params object[] args)
        {
            LogError(string.Format(message, args));
            MessageBox.Show(string.Format(message, args), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Logs the fatal.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        public static void LogFatal(string message, params object[] args)
        {
            _logger.Fatal(string.Format(message, args));
        }

        /// <summary>
        /// Logs the fatal and show message box.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        public static void LogFatalAndShowMessageBox(string message, params object[] args)
        {
            LogFatal(string.Format(message, args));
            MessageBox.Show(string.Format(message, args), "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        /// <summary>
        /// Logs the information.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        public static void LogInfo(string message, params object[] args)
        {
            _logger.Info(string.Format(message, args));
        }

        /// <summary>
        /// Logs the information and show message box.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        public static void LogInfoAndShowMessageBox(string message, params object[] args)
        {
            LogInfo(string.Format(message, args));
            MessageBox.Show(string.Format(message, args), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Logs the warning.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        public static void LogWarning(string message, params object[] args)
        {
            _logger.Warn(string.Format(message, args));
        }

        /// <summary>
        /// Logs the warning and show message box.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        public static void LogWarningAndShowMessageBox(string message, params object[] args)
        {
            LogWarning(string.Format(message, args));
            MessageBox.Show(string.Format(message, args), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
