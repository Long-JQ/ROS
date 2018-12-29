using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class ReturnData<T>
    {
        /// <summary>
        /// 代码
        /// </summary>
        public readonly int code;
        /// <summary>
        /// 消息
        /// </summary>
        public readonly string msg;
        /// <summary>
        /// 数据集合
        /// </summary>
        public readonly T data;
        /// <summary>
        /// 总条数
        /// </summary>

        public readonly int count;

        public ReturnData(CustomStatusCode code)
        {
            this.code = (int)code;
            this.msg = "";
            this.count = 0;
        }
        public ReturnData(CustomStatusCode code, string msg)
        {
            this.code = (int)code;
            this.msg = msg;
            this.count = 0;
        }
        public ReturnData(CustomStatusCode code, string msg, T data)
        {
            this.code = (int)code;
            this.msg = msg;
            this.data = data;
            this.count = 0;
        }
        public ReturnData(CustomStatusCode code, string msg, int count, T data)
        {
            this.code = (int)code;
            this.msg = msg;
            this.data = data;
            this.count = count;
        }
    }
    public enum CustomStatusCode
    {
        Success = 0, Error = 1, NotFound = 404, TimeOut = 1001
    }
}
