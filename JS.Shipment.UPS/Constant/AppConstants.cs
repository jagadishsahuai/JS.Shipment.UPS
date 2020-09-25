namespace JS.Shipment.UPS.Constant
{
    public static class AppConstants
    {
        public static readonly string[] BOOLEAN_TRUES = { "1", "Y", "y", "TRUE", "True", "true" };
        public static readonly string[] BOOLEAN_FALSES = { "0", "F", "f", "FALSE", "False", "false" };
        public static readonly char PACKAGE_TRACKING_NUMBER_DELIMETER = ',';
        public static readonly string IS_DELETED_DESCRIPTION = "VOIDED";
        public static readonly string IS_ALREADY_DELETED_DESCRIPTION = "ALREADY VOIDED";
        public static readonly string IS_PARTIALLY_DELETED_DESCRIPTION = "PARTIALLY VOIDED";
    }
}
