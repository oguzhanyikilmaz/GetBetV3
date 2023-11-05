using Newtonsoft.Json;

namespace GetBet.Business.NesineCom.Models.ResponseModels
{
    public class BulletinResponseModel
    {
        [JsonProperty("sg")]
        public Sg sg { get; set; }

        [JsonProperty("nsn")]
        public Nsn nsn { get; set; }
    }
}
