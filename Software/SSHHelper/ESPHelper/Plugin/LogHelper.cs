﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace ESPHelper.Plugin
{
    public enum LOG_LEVEL { DEBUG, INFO, ERROR } ;
    class LogHelper
    {
        /// <summary>
        /// 输出日志到Log4Net
        /// </summary>
        /// <param name="t"></param>
        /// <param name="ex"></param>
        #region static void WriteLog(Type t, Exception ex)

        public static void WriteLog(Type t, Exception ex)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(t);
            log.Error("Error", ex);
            
        }

        #endregion

        /// <summary>
        /// 输出日志到Log4Net
        /// </summary>
        /// <param name="t"></param>
        /// <param name="msg"></param>
        #region static void WriteLog(Type t, string msg)

        public static void WriteLog(Type t, string msg)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(t);           
            log.Info(msg);
        }

        public static void Write(LOG_LEVEL level,Type t, string msg)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(t);
           
            switch (level)
            {
                case LOG_LEVEL.DEBUG:
                    log.Debug(msg);
                    break;
                case LOG_LEVEL.INFO:
                    log.Info(msg);
                    break;
                case LOG_LEVEL.ERROR:
                    log.Error(msg);
                    break;
                default:
                    break;
            }
        }

        #endregion

    }
}
