﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;

namespace SientuoComm.Helper
{
    public class CacheHelper
    {
        static readonly MemoryCache cache = new(new MemoryCacheOptions());
        /// <summary>
        /// 创建缓存项的文件
        /// </summary>
        /// <param name="key">缓存Key</param>
        /// <param name="obj">object对象</param>
        public static void Set(string key, object value)
        {
            if (key != null)
            {
                cache.Set(key, value);
            }
        }
        /// <summary>
        /// 创建缓存项过期
        /// </summary>
        /// <param name="key">缓存Key</param>
        /// <param name="obj">object对象</param>
        /// <param name="expires">过期时间(秒)</param>
        public static void Set(string key, object value, int expires)
        {
            if (key != null)
            {
                cache.Set(key, value, new MemoryCacheEntryOptions()
                    //设置缓存时间，如果被访问重置缓存时间。设置相对过期时间x秒
                    .SetSlidingExpiration(TimeSpan.FromSeconds(expires)));
            }
        }


        /// <summary>
        /// 获取缓存对象
        /// </summary>
        /// <param name="key">缓存Key</param>
        /// <returns>object对象</returns>
        public static object Get(string key)
        {
            if (key != null && cache.TryGetValue(key, out object? val))
            {
                return val;
            }
            else
            {
                return default;
            }
        }

        /// <summary>
        /// 获取缓存对象
        /// </summary>
        /// <typeparam name="T">T对象</typeparam>
        /// <param name="key">缓存Key</param>
        /// <returns></returns>
        public static T? Get<T>(string key)
        {
            object obj = Get(key);
            return obj == null ? default : (T)obj;
        }


        /// <summary>
        /// 移除缓存项的文件
        /// </summary>
        /// <param name="key">缓存Key</param>
        public static void Remove(string key)
        {
            cache.Remove(key);
        }

    }
}
