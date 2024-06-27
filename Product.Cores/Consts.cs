namespace Products.Cores
{
    public class Consts
    {
        public static readonly string INVENTORY_QUANTITY_ERROR_MESSAGE = "在庫数を上回っています。もう一度入力してください。";
        public static readonly string PURCHASE_OVER_PRICE_ERROR_MESSAGE = "仕入価格が販売価格と同じか上回っています。もう一度入力してください。";
        public static readonly string INPUT_ERROR_MESSAGE = "不正な値が入力されました。";
        public static readonly string LESS_THAN_SALEDAY_ERROR_MESSAGE = "販売日が仕入日を下回っています。もう一度入力してください";
        public static readonly string SAME_PRODUCT_NAME_ERROR_MESSAGE = "同じ商品名が登録されています。もう一度入力してください";

        public const int CHECK_BOX_COLUMN = 0;
        public const int PRODUCT_NAME_COLUMN = 1;
        public const int SALE_PRICE_COLUMN = 2;
        public const int PURCHASE_DAY_COLUMN = 3;
        public const int SALE_DAY_COLUMN = 4;
        public const int SALE_QUANTITY_COLUMN = 5;
        public const int SALE_AMOUNT_COLUMN = 6;
    }
}