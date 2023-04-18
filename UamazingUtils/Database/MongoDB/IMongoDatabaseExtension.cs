using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uamazing.Utils.AttributeHelpers;
using Uamazing.Utils.Database.Attributes;
using Uamazing.Utils.Extensions;

namespace Uamazing.Utils.Database.MongoDB
{
    /// <summary>
    /// IMongoDatabase 扩展
    /// </summary>
    public static class IMongoDatabaseExtension
    {
        /// <summary>
        /// 通过类型来获取集合名称
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="mongoDatabase"></param>
        /// <returns></returns>
        public static IMongoCollection<T> GetCollection<T>(this IMongoDatabase mongoDatabase)
        {
            // 判断是否有 atrribute
            var att = AttributeHelper.GetAttribute<CollectionNameAttribute>(mongoDatabase.GetType());

            string collectionName;
            if (att == null) collectionName = typeof(T).Name;
            else
            {
                // 从 attribute 中获取
                collectionName = att.Name;
            }

            // 对名称进行格式化
            collectionName = collectionName.ToSnakeCase();

            // 返回集合
            return mongoDatabase.GetCollection<T>(collectionName);
        }
    }
}
