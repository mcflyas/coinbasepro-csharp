﻿using CoinbasePro.Services.Orders.Types;

namespace CoinbasePro.Specs.JsonFixtures.Services.Orders
{
    public static class OrderResponseFixture
    {
        public static string CreateMarketOrder()
        {
            var json = @"
{
    ""id"": ""d0c5340b-6d6c-49d9-b567-48c4bfca13d2"",
    ""price"": ""0.10000000"",
    ""size"": ""0.01000000"",
    ""product_id"": ""BTC-USD"",
    ""side"": ""buy"",
    ""stp"": ""dc"",
    ""type"": ""market"",
    ""time_in_force"": ""GTC"",
    ""post_only"": false,
    ""created_at"": ""2016-12-08T24:00:00Z"",
    ""fill_fees"": ""0.0000000000000000"",
    ""filled_size"": ""0.00000000"",
    ""executed_value"": ""0.0000000000000000"",
    ""status"": ""pending"",
    ""settled"": false
}";

            return json;
        }

        public static string CreateLimitOrder()
        {
            var json = @"
{
    ""id"": ""d0c5340b-6d6c-49d9-b567-48c4bfca13d2"",
    ""price"": ""0.10000000"",
    ""size"": ""0.01000000"",
    ""product_id"": ""BTC-USD"",
    ""side"": ""buy"",
    ""stp"": ""dc"",
    ""type"": ""limit"",
    ""time_in_force"": ""GTC"",
    ""post_only"": false,
    ""created_at"": ""2016-12-08T24:00:00Z"",
    ""fill_fees"": ""0.0000000000000000"",
    ""filled_size"": ""0.00000000"",
    ""executed_value"": ""0.0000000000000000"",
    ""status"": ""pending"",
    ""settled"": false
}";

            return json;
        }

        public static string CreateStopOrder()
        {
            var json = @"
{
    ""id"":""d0c5340b-6d6c-49d9-b567-48c4bfca13d2"",
    ""price"":""200"",
    ""size"":""0.01"",
    ""product_id"":""BTC-USD"",
    ""side"":""buy"",
    ""stp"":""dc"",
    ""type"":""limit"",
    ""time_in_force"":""GTC"",
    ""post_only"":false,
    ""stop"":""entry"",
    ""stop_price"":""100"",
    ""fill_fees"":""0"",
    ""filled_size"":""0"",
    ""executed_value"":""0"",
    ""status"":""pending"",
    ""settled"":false
}";

            return json;
        }

        public static string CreateLimitOrderMany(OrderStatus orderStatus = OrderStatus.Pending)
        {
            var json = $@"
[
    {{
        ""id"": ""d0c5340b-6d6c-49d9-b567-48c4bfca13d2"",
        ""price"": ""0.10000000"",
        ""size"": ""0.01000000"",
        ""product_id"": ""BTC-USD"",
        ""side"": ""buy"",
        ""stp"": ""dc"",
        ""type"": ""limit"",
        ""time_in_force"": ""GTC"",
        ""post_only"": false,
        ""created_at"": ""2016-12-08T24:00:00Z"",
        ""fill_fees"": ""0.0000000000000000"",
        ""filled_size"": ""0.00000000"",
        ""executed_value"": ""0.0000000000000000"",
        ""stop"": ""Entry"",
        ""stop_price"": ""100.0"",
        ""status"": ""{orderStatus.ToString().ToLower()}"",
        ""settled"": false
    }},
    {{    ""id"": ""8b99b139-58f2-4ab2-8e7a-c11c846e3022"",
        ""price"": ""0.10000000"",
        ""size"": ""0.01000000"",
        ""product_id"": ""ETH-USD"",
        ""side"": ""buy"",
        ""stp"": ""dc"",
        ""type"": ""limit"",
        ""time_in_force"": ""GTC"",
        ""post_only"": false,
        ""created_at"": ""2016-12-08T24:00:00Z"",
        ""fill_fees"": ""0.0000000000000000"",
        ""filled_size"": ""0.00000000"",
        ""executed_value"": ""0.0000000000000000"",
        ""status"": ""{orderStatus.ToString().ToLower()}"",
        ""settled"": false
    }}
]";

            return json;
        }
    }
}
