using System.Collections.Generic;

namespace ContentManagementSystem.Data.Entities
{
    public class PageContent : Entity
    {
        /// <summary>
        /// Page name in database
        /// </summary>
        public string PageName { get; set; }

        /// <summary>
        /// Page title
        /// </summary>
        public string PageTitle { get; set; }

        /// <summary>
        /// Page content
        /// </summary>
        public IList<ContentComponent> Content { get; set; }
    }
}