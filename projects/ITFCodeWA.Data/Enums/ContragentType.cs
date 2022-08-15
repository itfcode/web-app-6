using System.ComponentModel;

namespace ITFCodeWA.Data.Enums
{
    public enum ContractorType
    {
        [Description("Банк")]
        Bank = 10,

        [Description("Платежный сервис")]
        PayService = 15,

        [Description("Магазин, супермаркет")]
        Shop = 20,

        [Description("Кафе, бар, ресторан")]
        Cafe = 30,

        [Description("Интернет ТВ ")]
        InternetTvProvider = 40,

        [Description("")]
        InternetCableProvider = 50, // 

        [Description("Мобильный оператор")]
        MobileOperator = 60,

        [Description("Городской транспорт")]
        CityTransport = 70,

        [Description("Такси")]
        Taxi = 80,

        [Description("Коммунальное предприятие")]
        PublicService = 90,

        [Description("Автосервис")]
        AutoService = 100, // 

        [Description("Автозаправочная станция")]
        GasStation = 110, // 

        [Description("Поликлиника")]
        Policlinic = 120,

        [Description("Больница")]
        Hospital = 130,
    }
}
