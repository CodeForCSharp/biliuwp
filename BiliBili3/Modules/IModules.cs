﻿using BiliBili3.Helper;
using BiliBili3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BiliBili3.Modules
{
    public class IModules
    {

        public virtual ReturnModel HandelError(Exception ex)
        {
            if (LogHelper.IsNetworkError(ex))
            {
                return new ReturnModel()
                {
                    success = false,
                    message = "无法连接服务器，请检查网络连接"
                };
            }
            else
            {
                LogHelper.WriteLog(ex);
                return new ReturnModel()
                {
                    success = false,
                    message = "出现了一个未处理错误，已记录"
                };
            }
        }
        public virtual ReturnModel<T> HandelError<T>(Exception ex)
        {
            if (LogHelper.IsNetworkError(ex))
            {
                return new ReturnModel<T>()
                {
                    success = false,
                    message = "无法连接服务器，请检查网络连接"
                };
            }
            else
            {
                LogHelper.WriteLog(ex);
                return new ReturnModel<T>()
                {
                    success = false,
                    message = "出现了一个未处理错误，已记录"
                };
            }
        }

    }
}
