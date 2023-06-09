﻿using System;
using System.Text;
using Uamazing.Utils.Validate;

namespace Uamazing.Utils.Extensions
{
    /// <summary>
    /// MD5 验证器
    /// </summary>
    public static class MD5
    {
        /// <summary>
        /// 获得一个字符串的加密密文
        /// 此密文为单向加密，即不可逆(解密)密文
        /// </summary>
        /// <param name="plainText">待加密明文</param>
        /// <returns>已加密密文</returns>
        public static string EncryptMD5(this string plainText)
        {
            if (string.IsNullOrEmpty(plainText))
                throw new ArgumentNullException($"{nameof(plainText)}为空");
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();

            // 参考：https://www.cnblogs.com/qiufengke/p/5292621.html
            var bytHash = md5.ComputeHash(Encoding.UTF8.GetBytes(plainText));
            var sb = new StringBuilder();
            foreach (var b in bytHash)
            {
                sb.Append(b.ToString("X2"));
            }
            var encryptText = sb.ToString();

            return encryptText;
        }

        /// <summary>
        /// 判断明文与密文是否相符
        /// </summary>
        /// <param name="plainText">待检查的明文</param>
        /// <param name="encryptText">待检查的密文</param>
        /// <returns>bool</returns>
        public static bool EqualEncryptMD5(this string plainText, string encryptText)
        {
            if (string.IsNullOrEmpty(plainText) || string.IsNullOrEmpty(encryptText))
            {
                // throw new ArgumentNullException("明文或密文不存在");
                return false;
            }

            var md5Result = plainText.EncryptMD5();

            if (md5Result != encryptText)
            {

                // 明文与密文不匹配
                return false;
            }

            return true;
        }
    }
}
