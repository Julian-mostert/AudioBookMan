namespace AudioBookMan.Core.Audible.DTO.Requests
{
    public class CatalogProductsRequest
    {
        public CatalogProductsRequest()
        {
            this.ProductsSortBy = new List<string>
            {
                DTO.Const.ProductsSortBy.Relevance
            };
            this.ResponseGroups = new List<string>
            {
                Const.ResponseGroups.Contributors,
                Const.ResponseGroups.Media,
                Const.ResponseGroups.ProductAttrs,
                Const.ResponseGroups.ProductExtendedAttrs,
                Const.ResponseGroups.ProductDesc
            };
            this.NumberOfResults = Const.PagedNumbers.TwentyFive;

        }

        public string Author { get; set; }
        public string Keywords { get; set; }
        public string Narrator { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string NumberOfResults { get; set; }
        public string Page { get; set; }
        public IEnumerable<string> ProductsSortBy { get; set; }
        public IEnumerable<string> ResponseGroups { get; set; }

        // browse_type:
        // category_id: \d+(,\d+)*
        // disjunctive_category_ids:
        // image_dpi: \d+
        // image_sizes:
        // in_plan_timestamp:
        // not_in_plan_timestamp:
        // num_most_recent:
        // num_results: \d+ (max: 50)
    }
}
