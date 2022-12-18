namespace AudioBookMan.Core.Audible.DTO.Request;

public class CatalogProductByAsinRequest
{
    public CatalogProductByAsinRequest()
    {
        this.ResponseGroups = new List<string>
                              {
                                  Const.ResponseGroups.Contributors,
                                  Const.ResponseGroups.Media,
                                  Const.ResponseGroups.ProductAttrs,
                                  Const.ResponseGroups.ProductExtendedAttrs,
                                  Const.ResponseGroups.ProductDesc
                              };
    }

    public string ImageDpi { get; set; }

    public string ImageSizes { get; set; }

    // contributors,
    // media,
    // product_attrs,
    // product_desc,
    // product_extended_attrs,
    // product_plan_details,
    // product_plans,
    // rating,
    // review_attrs,
    // reviews,
    // sample,
    // sku
    public IEnumerable<string> ResponseGroups { get; set; }
    public string              Asins          { get; set; }
}


