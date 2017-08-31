using System;
using KenticoCloud.Delivery;

namespace KenticoCloudBase.Models
{
    public class CustomTypeProvider : ICodeFirstTypeProvider
    {
        public Type GetType(string contentType)
        {
            switch (contentType)
            {
                case "article":
                    return typeof(Article);
                default:
                    return null;
            }
        }
    }
}