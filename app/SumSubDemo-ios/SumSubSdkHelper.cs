using Foundation;
using SumSubstance.iOS;


namespace SumSubDemo_ios
{
    public static class SumSubSdkHelper
    {
        public static SSEngine GetInstance()
        {
            // TODO: [alex-d] maybe improve thread safety
            // by implementing double-check singleton pattern with mutex/lock
            // -

            if (_engineSingleton != null)
            {
                return _engineSingleton;
            }

            var colorConfig = new KYCColorConfig();
            var imageConfig = new KYCImageConfig();

            // https://developers.sumsub.com/msdk/ios.html#usage
            // -
            _engineSingleton = SSFacade.SetupForApplicant(
                applicantID: "", // your applicant identifier
                token: "", // your Sum&Sub auth token
                locale: NSLocale.CurrentLocale.LocaleIdentifier.ToString(),
                supportEmail: "",
                baseUrl: "test-msdk.sumsub.com", // baseUrl - test-msdk.sumsub.com for test environment or msdk.sumsub.com for production one
                colorConfig: colorConfig, // nil or subclass of KYCColorConfig (for color pallet customization)
                imageConfig: imageConfig  // nil or subclass of KYCImageConfig (for icons customization)
            );

            return _engineSingleton;
        }


        private static SSEngine _engineSingleton;

    }
}
