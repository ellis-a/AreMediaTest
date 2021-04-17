using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreMediaTest
{
    public class ContentBody
    {
        public string type { get; set; }
        public string label { get; set; }
        public object content { get; set; }
    }

    public class TagsDetail
    {
        public string name { get; set; }
        public string urlName { get; set; }
        public string fullName { get; set; }
        public string displayName { get; set; }
    }

    public class ContentVideo
    {
        public string id { get; set; }
    }

    public class ContentImageSize
    {
        public string type { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class ContentGallery
    {
        public string url { get; set; }
        public bool open { get; set; }
        public List<object> tags { get; set; }
        public string title { get; set; }
        public bool valid { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string source { get; set; }
        public string caption { get; set; }
        public List<object> credits { get; set; }
        public string mediaType { get; set; }
        public string creditText { get; set; }
        public bool? ispoen { get; set; }
        public string videoId { get; set; }
        public string videoTitle { get; set; }
        public int? brightcoveId { get; set; }
    }

    public class ContentFacebookImageUrl
    {
        public string url { get; set; }
        public List<object> tags { get; set; }
        public string title { get; set; }
        public bool valid { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string source { get; set; }
        public List<object> credits { get; set; }
    }

    public class Datum
    {
        public string id { get; set; }
        public string url { get; set; }
        public List<string> path { get; set; }
        public int level { get; set; }
        public string nodeId { get; set; }
        public string status { get; set; }
        public string siteUrl { get; set; }
        public string urlName { get; set; }
        public string nodeName { get; set; }
        public string parentID { get; set; }
        public string siteCode { get; set; }
        public string siteName { get; set; }
        public string pageOldId { get; set; }
        public string pageTitle { get; set; }
        public string parentUrl { get; set; }
        public string sectionId { get; set; }
        public string siteTitle { get; set; }
        public int sortOrder { get; set; }
        public string pageOldUrl { get; set; }
        public string parentName { get; set; }
        public List<ContentBody> contentBody { get; set; }
        public List<string> contentTags { get; set; }
        public int contentYear { get; set; }
        public int navIsHidden { get; set; }
        public List<TagsDetail> tagsDetails { get; set; }
        public int contentMonth { get; set; }
        public string contentTitle { get; set; }
        public ContentVideo contentVideo { get; set; }
        public string ampPreviewUrl { get; set; }
        public string articleSource { get; set; }
        public string nodeTypeAlias { get; set; }
        public string contentSummary { get; set; }
        public string moduleParentId { get; set; }
        public List<string> pageSearchTags { get; set; }
        public bool contentHasVideo { get; set; }
        public string contentImageUrl { get; set; }
        public DateTime nodeDateIndexed { get; set; }
        public DateTime pageDateCreated { get; set; }
        public ContentImageSize contentImageSize { get; set; }
        public List<string> nodeTypeAliasPath { get; set; }
        public bool isAllAmpCompatible { get; set; }
        public int contentAccessLevels { get; set; }
        public bool contentHasHeroVideo { get; set; }
        public string contentSummaryTitle { get; set; }
        public string pageMetaDescription { get; set; }
        public int pageExcludeFromSitemap { get; set; }
        public int pageExcludeDescendantsFromSitemap { get; set; }
        public DateTime updated_at { get; set; }
        public string source { get; set; }
        public List<ContentGallery> contentGallery { get; set; }
        public ContentFacebookImageUrl contentFacebookImageUrl { get; set; }
    }

    public class AreMedia
    {
        public int totalCount { get; set; }
        public List<Datum> data { get; set; }
    }


}
