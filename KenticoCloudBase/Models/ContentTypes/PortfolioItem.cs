// This code was generated by a cloud-generators-net tool 
// (see https://github.com/Kentico/cloud-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using KenticoCloud.Delivery;

namespace KenticoCloudBase.Models
{
    public partial class PortfolioItem
    {
        public const string Codename = "portfolio_item";
        public const string PostDateCodename = "post_date";
        public const string TitleCodename = "title";
        public const string FriendlyUrlCodename = "friendly_url";
        public const string DescriptionCodename = "description";
        public const string TopicCodename = "topic";
        public const string TechnologyCodename = "technology";
        public const string ServiceCodename = "service";
        public const string LargeImageCodename = "large_image";
        public const string PreviewImageCodename = "preview_image";
        public const string ThumbnailImageCodename = "thumbnail_image";

        public DateTime? PostDate { get; set; }
        public string Title { get; set; }
        public string FriendlyUrl { get; set; }
        public string Description { get; set; }
        public IEnumerable<TaxonomyTerm> Topic { get; set; }
        public IEnumerable<TaxonomyTerm> Technology { get; set; }
        public IEnumerable<TaxonomyTerm> Service { get; set; }
        public IEnumerable<Asset> LargeImage { get; set; }
        public IEnumerable<Asset> PreviewImage { get; set; }
        public IEnumerable<Asset> ThumbnailImage { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}