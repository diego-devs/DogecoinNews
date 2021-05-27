namespace CoinAPI.REST.V1.DataModels
{
    public class Icon
    {
        public string Id => exchange_id ?? asset_id;
        public string exchange_id { get; set; }
        public string asset_id { get; set; }
        public string url { get; set; }
    }
}
